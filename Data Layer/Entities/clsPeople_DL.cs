using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Data;
using static Data_Layer.clsQueries;
namespace Data_Layer.Entities
{
    public class clsPeople_DL
    {



        public static int? Add(MPeople people)
        {
            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPeople.Add, connection,CommandType.StoredProcedure);
                Utilities_DB.AddParametersWithValue(command, people);

                connection.Open();
                return Utilities_DB.Inserting_Execute(command);
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



    }


}
