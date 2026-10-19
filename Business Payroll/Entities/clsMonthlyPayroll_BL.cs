using Data_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Payroll.Entities
{
    public class clsMonthlyPayroll_BL
    {
    
    
    



        public static bool IsAllEmployeesInsertedForCurrentDate(DateTime FinancialDate)
        {



            return clsMonthlyPayroll_DL.IsAllEmployeesInsertedForCurrentDate(FinancialDate);

        }
    
    }



}
