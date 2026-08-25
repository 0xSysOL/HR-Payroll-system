using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Data;
using static Data_Layer.clsQueries;
namespace Data_Layer.Entities
{
    public class clsApplication_DL
    {



        public static int? Add(MApplication Structure)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQApplication.Add, connection, CommandType.StoredProcedure);

                Utilities_DB.AddParametersWithValue<MApplication>(command, Structure);
                connection.Open();
                return Convert.ToInt32(Utilities_DB.Scalar_Execute(command));

            }
        }

        public static bool Update(MApplication Structure)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQApplication.Update, connection, CommandType.StoredProcedure);


                command.Parameters.AddWithValue("@Status", Structure.Status);
                command.Parameters.AddWithValue("@ApplicationID", Structure.ApplicationID);

                connection.Open();
                return Convert.ToInt32(Utilities_DB.ExecuteNoneQu(command)) == 1;


            }


        }


        public static List<MApplication> SelectRecords(int PageNumber, int RowPerPage)
        {
            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command
                    (clsQApplication.SelectRecords, connection, CommandType.StoredProcedure);


                Utilities_DB.AddPaginationToSqlCommand(command,PageNumber, RowPerPage);

                connection.Open();

                return Utilities_DB.ConvertRowsToClassesOB<MApplication>(Utilities_DB._SelectRecords_Execute(command));
            }



        }


        public static MApplication GetApplication(int ID)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQApplication.GetApplicationByID, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("@ApplicationID", ID);

                connection.Open();
                List<Dictionary<string, object>> List = new List<Dictionary<string, object>>();
                List.Add(Utilities_DB._SelectRecordsWithWhere_Execute<MApplication>(command));

                return Utilities_DB.ConvertRowsToClassesOB<MApplication>(List).First();

            }
        }


    }


}
