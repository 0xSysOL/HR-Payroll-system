using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Data;
using static Data_Layer.clsQueries;
using static Data_Layer.Utilities_DB;
namespace Data_Layer.Entities
{
    public class clsDepartment_DL
    {

        public static int? Add(MDepartment Ob_Department)
        {
            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = GetSQL_Command(clsQDepartment.Add, connection,CommandType.StoredProcedure);

                AddParametersWithValue(command, Ob_Department);

                connection.Open();

                return Inserting_Execute(command);
            }


        }


    }


}
