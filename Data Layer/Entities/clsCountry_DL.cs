using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using static Data_Layer.Configuration.clsSetting;
using static Data_Layer.Utilities_DB;
using static Data_Layer.clsQueries;
namespace Data_Layer.Entities
{
    public class clsCountry_DL
    {
         
        public static List<MCountry> GetData(int PageNumber, int RowPerPage)
        {

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = GetSQL_Command(clsQCountry.GetAll, connection,CommandType.StoredProcedure);

                AddPaginationToSqlCommand(command, PageNumber, RowPerPage);
                connection.Open();
                return ConvertRowsToClassesOB<MCountry>(SelectRecords_Execute(command));
            

            }

        }



    }


}
