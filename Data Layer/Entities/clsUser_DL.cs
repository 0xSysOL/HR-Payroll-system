using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static DataTable GetAll()
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.GetAll, connection,CommandType.StoredProcedure);



                connection.Open();
                return Utilities_DB.SelectRecords_Execute(command);


            }


        }
        public static DataTable SelectRecords(MUser Structure)
        {


            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQUser.SelectRecords, connection, CommandType.StoredProcedure);


                command.Parameters.AddWithValue
                    ("ColumnNames", Utilities_DB.AddParametersToString(command, Structure));
                connection.Open();


                return Utilities_DB.SelectRecords_Execute(command);


            }


        }

    }


}
