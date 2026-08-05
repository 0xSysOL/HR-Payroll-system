using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Data;
using static Data_Layer.clsQueries;

namespace Data_Layer.Entities
{
    public class clsUser_DL
    {
        public static int? Add(MUser User)
        {



            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.Add, connection, CommandType.StoredProcedure);

                Utilities_DB.AddParametersWithValue(command, User);

                connection.Open();
                return Utilities_DB.Inserting_Execute(command);


            }
        }

        public static bool Update(MUser User)
        {


            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.Update, connection, CommandType.StoredProcedure);

                Utilities_DB.AddParametersWithValue(command, User);

                connection.Open();
                return Convert.ToBoolean(Utilities_DB.Scalar_Execute(command));


            }

        }
        public static DataTable GetAll()
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.GetAll, connection, CommandType.StoredProcedure);



                connection.Open();
                return Utilities_DB.SelectRecords_Execute(command);


            }


        }
        public static DataTable SelectRecords(MUser Structure)
        {


            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.SelectRecords, connection, CommandType.StoredProcedure);


                command.Parameters.AddWithValue
                    ("ColumnNames", Utilities_DB.AddParametersToString(command, Structure));
                connection.Open();


                return Utilities_DB.SelectRecords_Execute(command);


            }


        }


        public static DataTable GetUser(int UserID)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.GetUser, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("UserID", UserID);

                connection.Open();

                return Utilities_DB.SelectRecords_Execute(command);

            }


        }


        public static bool IsUserIDExists(int UserID)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.IsUserIDExists, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("UserID", UserID);
                connection.Open();
                short Result = Convert.ToInt16(Utilities_DB.Scalar_Execute(command));
                return Result != 0 ? true : false;

            }


            
        }
        public static bool DeleteUser(int UserID)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.DeleteUser,connection,CommandType.StoredProcedure);
                command.Parameters.AddWithValue("UserID", UserID);
                connection.Open();
                short Result = Convert.ToInt16(Utilities_DB.ExecuteNoneQu(command));
                return Result != 0 ? true : false;
            }


        }



        public static bool IsUsernameExists(string Username)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.IsUsernameExists, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("Username", Username);
                connection.Open();
                short Result = Convert.ToInt16(Utilities_DB.Scalar_Execute(command));
                return Result != 0 ? true : false;

            }
        }

    }


}
