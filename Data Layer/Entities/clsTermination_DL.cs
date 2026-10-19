using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.CommandType;
using static Data_Layer.clsQueries;
namespace Data_Layer.Entities
{
    public class clsTermination_DL
    {
         
        public static int? Add(MTermination Structure)
        {

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQTermination.Add, connection, CommandType.StoredProcedure);
                Utilities_DB.AddParametersWithValue<MTermination>(command, Structure);
                connection.Open();
                return Convert.ToInt32(Utilities_DB.Inserting_Execute(command));
            }



        }


    }


}
