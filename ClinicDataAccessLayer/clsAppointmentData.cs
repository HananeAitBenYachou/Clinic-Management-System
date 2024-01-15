using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsAppointmentData
    {
        public static bool GetAppointmentInfoByID(int AppointmentID, ref int PatientID, ref int DoctorID, ref DateTime AppointmentDateTime, ref short AppointmentStatus, ref int? MedicalRecordID, ref int? PaymentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Appointments 
                            WHERE AppointmentID = @AppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PatientID = (int)reader["PatientID"];
                    DoctorID = (int)reader["DoctorID"];
                    AppointmentDateTime = (DateTime)reader["AppointmentDateTime"];
                    AppointmentStatus = (short)reader["AppointmentStatus"];
                    if (reader["MedicalRecordID"] != DBNull.Value)
                        MedicalRecordID = (int)reader["MedicalRecordID"];
                    else
                        MedicalRecordID = null;
                    if (reader["PaymentID"] != DBNull.Value)
                        PaymentID = (int)reader["PaymentID"];
                    else
                        PaymentID = null ;

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

        public static bool IsAppointmentExist(int AppointmentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 
                             FROM Appointments
                             WHERE AppointmentID = @AppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        public static bool IsAppointmentDateFree(int DoctorID, DateTime AppointmentDateTime)
        {
            bool isDateBusy = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isDateBusy = 1
                            FROM Appointments
                            WHERE DoctorID = @DoctorID AND AppointmentDateTime = @AppointmentDateTime AND AppointmentStatus != 4;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);


            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                isDateBusy = (reader != null);
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return !isDateBusy;
        }

        public static bool IsAppointmentFeesPaid(int AppointmentID)
        {
            bool isPaid = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isPaid = 1
                            FROM Appointments
                            WHERE AppointmentID = @AppointmentID AND PaymentID IS NOT NULL;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                isPaid = (reader != null);
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return isPaid;
        }
        
        public static int AddNewAppointment(int PatientID, int DoctorID, DateTime AppointmentDateTime, short AppointmentStatus, int? MedicalRecordID, int? PaymentID)
        {
            int AppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Appointments (PatientID,DoctorID,AppointmentDateTime,AppointmentStatus,MedicalRecordID,PaymentID)
                            VALUES (@PatientID,@DoctorID,@AppointmentDateTime,@AppointmentStatus,@MedicalRecordID,@PaymentID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
            command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            if (MedicalRecordID != null)
            {
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            }
            else
                command.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);
            if (PaymentID != null)
            {
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
            }
            else
                command.Parameters.AddWithValue("@PaymentID", DBNull.Value);


            object reader = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int InsertedID))
                {
                    AppointmentID = InsertedID;
                }
            }

            catch (Exception ex)
            {
                AppointmentID = -1;
            }

            finally
            {
                connection.Close();
            }

            return AppointmentID;
        }

        public static bool UpdateAppointmentInfo(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, short AppointmentStatus, int? MedicalRecordID, int? PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Appointments
                            SET 
							PatientID = @PatientID,
							DoctorID = @DoctorID,
							AppointmentDateTime = @AppointmentDateTime,
							AppointmentStatus = @AppointmentStatus,
							MedicalRecordID = @MedicalRecordID,
							PaymentID = @PaymentID
                            WHERE AppointmentID = @AppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
            command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            if (MedicalRecordID != null)
            {
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            }
            else
                command.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);
            if (PaymentID != null)
            {
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
            }
            else
                command.Parameters.AddWithValue("@PaymentID", DBNull.Value);

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

        public static bool DeleteAppointment(int AppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Appointments
                              WHERE AppointmentID = @AppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        public static DataTable GetAllAppointments()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT AppointmentID , PatientID , DoctorID , AppointmentDateTime , 
                            CASE 
	                            WHEN AppointmentStatus = 1 THEN 'Completed'
	                            WHEN AppointmentStatus = 2 THEN 'Pending'
	                            WHEN AppointmentStatus = 3 THEN 'Confirmed'
	                            WHEN AppointmentStatus = 4 THEN 'Cancelled'
	                            WHEN AppointmentStatus = 5 THEN 'Rescheduled'
	                            ELSE 'Unattended' 
                            END AS AppointmentStatus , MedicalRecordID , PaymentID
                            FROM Appointments;";

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

        public static short GetNumberOfAppointments()
        {
            short count = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) 
                             FROM Appointments;";

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
