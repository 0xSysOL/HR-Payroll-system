using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using static Data_Layer.Configuration.clsSetting;
using static Data_Layer.Utilities_DB;

namespace Data_Layer.Entities
{
    public class clsCountry_DL
    {

        public static DataTable GetAll()
        {

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = GetSQL_Command(clsQueries.clsQCountry.GetAll, connection,CommandType.StoredProcedure);


                connection.Open();
                return SelectRecords_Execute(command);
            

            }

        }



    }


}
