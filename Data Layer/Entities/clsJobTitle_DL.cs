using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Layer.Configuration;
namespace Data_Layer.Entities
{
    public class clsJobTitle_DL
    {
    

        public static int? Add(string Title)
        {

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQueries.clsQJobTitle.Add, connection, CommandType.StoredProcedure);
                connection.Open();
                command.Parameters.AddWithValue("Title", Title);
                return Utilities_DB.Inserting_Execute(command); 

            }


        }
    
    
    }



}
