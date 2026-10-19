using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
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
    public class clsPayrollReport_DL
    {

        public static int Add(DateTime FinancialDate, int CreateByUserID)
        {

            using(SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command("None",connection,CommandType.StoredProcedure);
                command.Parameters.AddWithValue("@FinancialDate", FinancialDate);
                command.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);

                object Result = Utilities_DB.Scalar_Execute(command);
                return Result != null ? Convert.ToInt32(Result) : -1;

            }


        }


        public static bool IsFinancialDateExists(DateTime FinancialDate)
        {
            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = Utilities_DB.GetSQL_Command(clsQPayrollReport.IsFinancialDateExists, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("@FinancialDate", FinancialDate.Date);

                connection.Open();
                return Convert.ToBoolean(Utilities_DB.Scalar_Execute(command));

            }
        }
    }


}
