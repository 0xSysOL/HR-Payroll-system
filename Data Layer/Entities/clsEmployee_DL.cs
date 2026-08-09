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
                Utilities_DB.AddValueToManagerID(command, Structure.Manager_ID);
                connection.Open();
                object Result = Utilities_DB.Scalar_Execute(command);
                return Result != null ? Convert.ToInt32(Result) : null;


            }


        }
        public static bool Update(MEmployee Structure)
        {


            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQEmployee.Update, connection, CommandType.StoredProcedure);


                Utilities_DB.AddParametersWithValue(command, Structure);
                Utilities_DB.AddValueToManagerID(command, Structure.Manager_ID);

                connection.Open();
                return Convert.ToBoolean(Utilities_DB.ExecuteNoneQu(command));
                



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

        public static DataTable GetEmployeeByID(int EmployeeID)
        {

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {

                SqlCommand command = Utilities_DB.GetSQL_Command(clsQEmployee.GetEmployeeByID, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("EmployeeID", EmployeeID);

                connection.Open();
                return Utilities_DB.SelectRecords_Execute(command);
            }

        }

    }


}
