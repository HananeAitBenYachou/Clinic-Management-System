using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsPaymentData
    {
        public static bool GetPaymentInfoByID(int PaymentID, ref DateTime PaymentDate, ref string PaymentMethod, ref double AmountPaid, ref string AdditionalNotes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Payments 
                            WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PaymentDate = (DateTime)reader["PaymentDate"];

                    if (reader["PaymentMethod"] != DBNull.Value)
                        PaymentMethod = (string)reader["PaymentMethod"];
                    else
                        PaymentMethod = "";

                    AmountPaid = Convert.ToDouble(reader["AmountPaid"]);

                    if (reader["AdditionalNotes"] != DBNull.Value)
                        AdditionalNotes = (string)reader["AdditionalNotes"];
                    else
                        AdditionalNotes = "";
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return isFound;
        }

        public static bool IsPaymentExist(int PaymentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 
                             FROM Payments
                             WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                isFound = (reader != null);
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewPayment(DateTime PaymentDate, string PaymentMethod, double AmountPaid, string AdditionalNotes)
        {
            int PaymentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Payments (PaymentDate,PaymentMethod,AmountPaid,AdditionalNotes)
                            VALUES (@PaymentDate,@PaymentMethod,@AmountPaid,@AdditionalNotes);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            if (PaymentMethod != "")
            {
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            }
            else
                command.Parameters.AddWithValue("@PaymentMethod", DBNull.Value);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            if (AdditionalNotes != "")
            {
                command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            }
            else
                command.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);


            object reader = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int InsertedID))
                {
                    PaymentID = InsertedID;
                }
            }

            catch (Exception ex)
            {
                PaymentID = -1;
            }

            finally
            {
                connection.Close();
            }

            return PaymentID;
        }

        public static bool UpdatePaymentInfo(int PaymentID, DateTime PaymentDate, string PaymentMethod, double AmountPaid, string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Payments
                            SET 
							PaymentDate = @PaymentDate,
							PaymentMethod = @PaymentMethod,
							AmountPaid = @AmountPaid,
							AdditionalNotes = @AdditionalNotes
                            WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            if (PaymentMethod != "")
            {
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            }
            else
                command.Parameters.AddWithValue("@PaymentMethod", DBNull.Value);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            if (AdditionalNotes != "")
            {
                command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            }
            else
                command.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return rowsAffected != 0;
        }

        public static bool DeletePayment(int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Payments
                              WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return rowsAffected != 0;
        }

        public static DataTable GetAllPayments()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Payments.PaymentID , Appointments.PatientID , PaymentDate ,
                            PaymentMethod , AmountPaid , AdditionalNotes
                            FROM Payments INNER JOIN Appointments ON Payments.PaymentID = Appointments.PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }

            catch (Exception ex) { }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return dataTable;
        }

        public static short GetNumberOfPayments()
        {
            short count = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) 
                             FROM Payments ;";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && short.TryParse(reader.ToString(), out short _count))
                {
                    count = _count;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return count;
        }

    }
}
