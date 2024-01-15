using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsPrescriptionData
    {
        public static bool GetPrescriptionInfoByID(int PrescriptionID, ref int MedicalRecordID, ref string MedicationName, ref string Dosage, ref string Frequency, ref DateTime StartDate, ref DateTime EndDate, ref string SpecialInstructions)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Prescriptions 
                            WHERE PrescriptionID = @PrescriptionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    MedicalRecordID = (int)reader["MedicalRecordID"];
                    MedicationName = (string)reader["MedicationName"];
                    Dosage = (string)reader["Dosage"];
                    Frequency = (string)reader["Frequency"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];
                    if (reader["SpecialInstructions"] != DBNull.Value)
                        SpecialInstructions = (string)reader["SpecialInstructions"];
                    else
                        SpecialInstructions = "";

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

        public static bool IsPrescriptionExist(int PrescriptionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 
                             FROM Prescriptions
                             WHERE PrescriptionID = @PrescriptionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

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

        public static int AddNewPrescription(int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            int PrescriptionID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Prescriptions (MedicalRecordID,MedicationName,Dosage,Frequency,StartDate,EndDate,SpecialInstructions)
                            VALUES (@MedicalRecordID,@MedicationName,@Dosage,@Frequency,@StartDate,@EndDate,@SpecialInstructions);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            command.Parameters.AddWithValue("@MedicationName", MedicationName);
            command.Parameters.AddWithValue("@Dosage", Dosage);
            command.Parameters.AddWithValue("@Frequency", Frequency);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            if (SpecialInstructions != "")
            {
                command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
            }
            else
                command.Parameters.AddWithValue("@SpecialInstructions", DBNull.Value);


            object reader = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int InsertedID))
                {
                    PrescriptionID = InsertedID;
                }
            }

            catch (Exception ex)
            {
                PrescriptionID = -1;
            }

            finally
            {
                connection.Close();
            }

            return PrescriptionID;
        }

        public static bool UpdatePrescriptionInfo(int PrescriptionID, int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Prescriptions
                            SET 
							MedicalRecordID = @MedicalRecordID,
							MedicationName = @MedicationName,
							Dosage = @Dosage,
							Frequency = @Frequency,
							StartDate = @StartDate,
							EndDate = @EndDate,
							SpecialInstructions = @SpecialInstructions
                            WHERE PrescriptionID = @PrescriptionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            command.Parameters.AddWithValue("@MedicationName", MedicationName);
            command.Parameters.AddWithValue("@Dosage", Dosage);
            command.Parameters.AddWithValue("@Frequency", Frequency);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            if (SpecialInstructions != "")
            {
                command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
            }
            else
                command.Parameters.AddWithValue("@SpecialInstructions", DBNull.Value);

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

        public static bool DeletePrescription(int PrescriptionID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Prescriptions
                              WHERE PrescriptionID = @PrescriptionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

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

        public static DataTable GetAllPrescriptions()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Prescriptions;";

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

        public static short GetNumberOfPrescriptions()
        {
            short count = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) 
                             FROM Prescriptions ;";

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
