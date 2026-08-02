using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Data;
using static Data_Layer.clsQueries;
namespace Data_Layer.Entities
{
    public class clsPeople_DL
    {



        public static int? Add(MPeople Person)
        {
            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPeople.Add, connection,CommandType.StoredProcedure);
                Utilities_DB.AddParametersWithValue(command, Person);

                connection.Open();
                return Utilities_DB.Inserting_Execute(command);
            }  



        }

        public static bool Update(MPeople Person)
        {

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPeople.Update,
                    connection, CommandType.StoredProcedure);

                Utilities_DB.AddParametersWithValue(command,Person);
                

                connection.Open();
                object Result = Utilities_DB.ExecuteNoneQu(command);

                return (Result != null) ? true : false;


            }



        }

        public static DataTable GetAll()
        {

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPeople.GetAll, connection, CommandType.StoredProcedure);
                connection.Open();
                return Utilities_DB.SelectRecords_Execute(command);
            }

        }

        public static DataTable SelectRecords(MPeople Structure)
        { 

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPeople.SelectRecords, connection, CommandType.StoredProcedure);


               command.Parameters.AddWithValue("@ColumnNames", Utilities_DB.AddParametersToString(command, Structure));

                connection.Open();
                return Utilities_DB.SelectRecords_Execute(command);
            }

        }

        public static bool IsNationalNoExists(string NationalNo)
        {
            bool IsExists = false;

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPeople.IsNationalNoExists, connection, CommandType.StoredProcedure);

                command.Parameters.AddWithValue("NationalNo", NationalNo);

                connection.Open();
                IsExists = Utilities_DB.Scalar_Execute(command) != null;

            }

            return IsExists;
        }


        public static DataTable GetPersonByID(int PersonID)
        {


            DataTable data = new DataTable();

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPeople.GetPersonIDByID, connection, CommandType.StoredProcedure);

                command.Parameters.AddWithValue("PersonID", PersonID);

                connection.Open();
                data = Utilities_DB.SelectRecords_Execute(command);




            }

            return data;
        }



        public static bool Delete(int PersonID)
        {

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPeople.Delete,connection,CommandType.StoredProcedure);
                command.Parameters.AddWithValue("PersonID",PersonID);

                connection.Open();
                object Result = Utilities_DB.ExecuteNoneQu(command);
                return Result != null ? true : false;


            }


            return false;
        }
    }


}
