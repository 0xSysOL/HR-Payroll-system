using Data_Layer.Entities;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Business_Payroll.Entities
{
    public class clsPayrollReport_BL
    {

 
        public clsPayrollReport_BL()
        {
        }

        public int Add(DateTime FinancialDate, int CreateByUserID)
        {
            return -1;

            if (IsFinancialDateExists(FinancialDate))
                return -1;
            
            
      

            return clsPayrollReport_DL.Add(FinancialDate, CreateByUserID);
        }


        public static bool IsFinancialDateExists(DateTime FinancialDate)
        {


            return clsPayrollReport_DL.IsFinancialDateExists(FinancialDate);

        }
    }


}
