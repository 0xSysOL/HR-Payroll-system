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

                Utilities_DB.AddParametersWithValue<MUser>(command, User);

                connection.Open();
                return Utilities_DB.Inserting_Execute(command);


            }
        }

        public static bool Update(MUser User)
        {


            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.Update, connection, CommandType.StoredProcedure);

                Utilities_DB.AddParametersWithValue<MUser>(command, User);

                connection.Open();
                return Convert.ToBoolean(Utilities_DB.Scalar_Execute(command));


            }

        }

        public static List<MUser> SelectRecordsAndChooseColumns(MUser Structure)
        {


            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.SelectRecordsAndChooseColumns, connection, CommandType.StoredProcedure);


                command.Parameters.AddWithValue("ColumnNames", Utilities_DB.AddParametersToString<MUser>(Structure));
                connection.Open();
                return Utilities_DB.ConvertRowsToClassesOB<MUser>(Utilities_DB.SelectRecords_Execute(command));

            }


        }
        public static List<MUser> SelectRecords(int PageNumber, int RowPerPage)
        {
            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.SelectRecords, connection, CommandType.StoredProcedure);
                Utilities_DB.AddPaginationToSqlCommand(command, PageNumber, RowPerPage);
                connection.Open();
                return Utilities_DB.ConvertRowsToClassesOB<MUser>(Utilities_DB.SelectRecords_Execute(command));

            }
        }


        public static MUser? GetUserByID(int UserID)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.GetUserByID, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("UserID", UserID);
                connection.Open();
                return Utilities_DB.ConvertRowToClassesOB<MUser>(Utilities_DB.SelectRecords_Execute(command));
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
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.DeleteUser, connection, CommandType.StoredProcedure);
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
