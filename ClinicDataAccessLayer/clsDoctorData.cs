using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsDoctorData
    {
        public static bool GetDoctorInfoByID(int DoctorID, ref int PersonID, ref int SpecializationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Doctors 
                            WHERE DoctorID = @DoctorID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    SpecializationID = (int)reader["SpecializationID"];

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

        public static bool IsDoctorExist(int DoctorID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 
                             FROM Doctors 
                             WHERE DoctorID = @DoctorID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);

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

        public static bool IsDoctorExistByPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT isFound = 1 
                             FROM Doctors 
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static int AddNewDoctor(int PersonID, int SpecializationID)
        {
            int DoctorID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Doctors (PersonID,SpecializationID)
                            VALUES (@PersonID,@SpecializationID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);


            object reader = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int InsertedID))
                {
                    DoctorID = InsertedID;
                }
            }

            catch (Exception ex)
            {
                DoctorID = -1;
            }

            finally
            {
                connection.Close();
            }

            return DoctorID;
        }

        public static bool UpdateDoctorInfo(int DoctorID, int PersonID, int SpecializationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Doctors
                            SET 
							PersonID = @PersonID,
							SpecializationID = @SpecializationID
                            WHERE DoctorID = @DoctorID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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

        public static bool DeleteDoctor(int DoctorID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Doctors
                              WHERE DoctorID = @DoctorID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);

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

        public static DataTable GetAllDoctors()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Doctors.DoctorID ,People.Name, People.DateOfBirth ,
                            People.Gender , People.PhoneNumber , People.Email ,
                            People.Address , Specializations.Name as 'Speciality' 
                            FROM Doctors 
                            INNER JOIN Specializations ON Doctors.SpecializationID = Specializations.SpecializationID
                            INNER JOIN People ON Doctors.PersonID = People.PersonID;";

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

        public static short GetNumberOfDoctors()
        {
            short count = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) 
                             FROM Doctors;";

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
