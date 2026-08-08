using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Data;
using static Data_Layer.clsQueries;
namespace Data_Layer.Entities
{
    public class clsEmployee_DL
    {



        public static int? Add(MEmployee Structure)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {

                SqlCommand command = Utilities_DB.GetSQL_Command(clsQEmployee.Add, connection, CommandType.StoredProcedure);
                Utilities_DB.AddParametersWithValue(command, Structure);
                if (Structure.Manager_ID == null)
                    command.Parameters.AddWithValue("@ManagerID", DBNull.Value);

                connection.Open();
                object Result = Utilities_DB.Scalar_Execute(command);
                return Result != null ? Convert.ToInt32(Result) : null;


            }


        }
        public static bool? Update(MEmployee Structure)
        {


            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command("None", connection, CommandType.StoredProcedure);

                return Convert.ToBoolean(Utilities_DB.ExecuteNoneQu(command));
                // here work 
            }

        }

        public static bool IsEmployeeExists(int EmployeeID)
        {
            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQEmployee.IsEmployeeExists, connection,CommandType.StoredProcedure);

                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                connection.Open();

                object Result = Utilities_DB.Scalar_Execute(command);
                return Convert.ToBoolean(Result);
            }
        }

    }


}
