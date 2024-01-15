using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsSpecializationData
    {
        public static bool GetSpecializationInfoByID(int SpecializationID, ref string Name, ref string Description)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Specializations 
                            WHERE SpecializationID = @SpecializationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Name = (string)reader["Name"];
                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = "";

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

        public static bool IsSpecializationExist(int SpecializationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 
                             FROM Specializations
                             WHERE SpecializationID = @SpecializationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);

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

        public static bool IsSpecializationExist(string Name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 
                             FROM Specializations
                             WHERE Name = @Name;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

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

        public static int AddNewSpecialization(string Name, string Description)
        {
            int SpecializationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Specializations (Name,Description)
                            VALUES (@Name,@Description);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            if (Description != "")
            {
                command.Parameters.AddWithValue("@Description", Description);
            }
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);


            object reader = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int InsertedID))
                {
                    SpecializationID = InsertedID;
                }
            }

            catch (Exception ex)
            {
                SpecializationID = -1;
            }

            finally
            {
                connection.Close();
            }

            return SpecializationID;
        }

        public static bool UpdateSpecializationInfo(int SpecializationID, string Name, string Description)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Specializations
                            SET 
							Name = @Name,
							Description = @Description
                            WHERE SpecializationID = @SpecializationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
            command.Parameters.AddWithValue("@Name", Name);
            if (Description != "")
            {
                command.Parameters.AddWithValue("@Description", Description);
            }
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

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

        public static bool DeleteSpecialization(int SpecializationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Specializations
                              WHERE SpecializationID = @SpecializationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);

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

        public static DataTable GetAllSpecializations()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Specializations;";

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

        public static short GetNumberOfSpecializations()
        {
            short count = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) 
                             FROM Specializations;";

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
