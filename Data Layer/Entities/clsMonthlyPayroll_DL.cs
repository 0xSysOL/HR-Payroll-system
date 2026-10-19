using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;

namespace Data_Layer.Entities
{
    public class clsMonthlyPayroll_DL
    {



        public static bool IsAllEmployeesInsertedForCurrentDate(DateTime FinancialDate)
        {
            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {




            }


            return false;
        }

    }


}
