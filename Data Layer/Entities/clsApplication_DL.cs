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

                Utilities_DB.AddParametersWithValue(command, Structure);
                connection.Open();
                return Convert.ToInt32(Utilities_DB.Scalar_Execute(command));

            }
        }

        public static bool Update(MApplication Structure)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQApplication.Update, connection, CommandType.StoredProcedure);

              
                command.Parameters.AddWithValue("@Status",Structure.Status);
                command.Parameters.AddWithValue("@ApplicationID", Structure.Application_ID);

                connection.Open();
                return Convert.ToInt32(Utilities_DB.ExecuteNoneQu(command)) == 1;


            }


        }





    }


}
