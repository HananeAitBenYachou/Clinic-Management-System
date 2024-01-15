using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsMedicalRecordData
    {
        public static bool GetMedicalRecordInfoByID(int MedicalRecordID, ref string VisitDescription, ref string Diagnosis, ref string AdditionalNotes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM MedicalRecords 
                            WHERE MedicalRecordID = @MedicalRecordID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    if (reader["VisitDescription"] != DBNull.Value)
                        VisitDescription = (string)reader["VisitDescription"];
                    else
                        VisitDescription = "";

                    if (reader["Diagnosis"] != DBNull.Value)
                        Diagnosis = (string)reader["Diagnosis"];
                    else
                        Diagnosis = "";

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

        public static bool IsMedicalRecordExist(int MedicalRecordID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 
                             FROM MedicalRecords
                             WHERE MedicalRecordID = @MedicalRecordID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

        public static int AddNewMedicalRecord(string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            int MedicalRecordID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO MedicalRecords (VisitDescription,Diagnosis,AdditionalNotes)
                            VALUES (@VisitDescription,@Diagnosis,@AdditionalNotes);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            if (VisitDescription != "")
            {
                command.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            }
            else
                command.Parameters.AddWithValue("@VisitDescription", DBNull.Value);
            if (Diagnosis != "")
            {
                command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            }
            else
                command.Parameters.AddWithValue("@Diagnosis", DBNull.Value);
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
                    MedicalRecordID = InsertedID;
                }
            }

            catch (Exception ex)
            {
                MedicalRecordID = -1;
            }

            finally
            {
                connection.Close();
            }

            return MedicalRecordID;
        }

        public static bool UpdateMedicalRecordInfo(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE MedicalRecords
                            SET 
							VisitDescription = @VisitDescription,
							Diagnosis = @Diagnosis,
							AdditionalNotes = @AdditionalNotes
                            WHERE MedicalRecordID = @MedicalRecordID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

            if (VisitDescription != "")
            {
                command.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            }
            else
                command.Parameters.AddWithValue("@VisitDescription", DBNull.Value);
            if (Diagnosis != "")
            {
                command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            }
            else
                command.Parameters.AddWithValue("@Diagnosis", DBNull.Value);
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

        public static bool DeleteMedicalRecord(int MedicalRecordID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE MedicalRecords
                              WHERE MedicalRecordID = @MedicalRecordID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

        public static DataTable GetAllMedicalRecords()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT MedicalRecords.MedicalRecordID,People.Name as PatientName,VisitDescription,Diagnosis,AdditionalNotes
                            FROM MedicalRecords
                            INNER JOIN Appointments ON Appointments.MedicalRecordID = MedicalRecords.MedicalRecordID
                            INNER JOIN Patients ON Appointments.PatientID = Patients.PatientID
                            INNER JOIN People ON Patients.PersonID = People.PersonID ;";

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

        public static short GetNumberOfMedicalRecords()
        {
            short count = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) 
                             FROM MedicalRecords;";

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
