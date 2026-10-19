using Models.Entities;
using Models.Enums;
using System.ComponentModel.Design;
using static Models.Enums.M_Enums;

namespace Business___HR.Validations
{
    internal class MEmployeeValidations
    {


        public static bool IsEmpty(MEmployee employee) => employee == null;
        public static bool Is_eEmployeeEmpty(M_eColumnsName.eEmployee[] eEm) => eEm == null;
        public static bool CheckFromInputs_IsNull(MEmployee StrEmployee,bool IsInserting)
        {

            if (StrEmployee.EmployeeID == null && !IsInserting)
                return true;
            else if (StrEmployee.CreateByUserID == null)
                return true;
            else if (StrEmployee.DepartmentID == null)
                return true;
            else if (StrEmployee.PersonID == null)
                return true;
            else if (StrEmployee.HireDate == null)
                return true;
            else if (StrEmployee.JobTitleID == null)
                return true;
            else if (StrEmployee.EmployeeSalary == null)
                return true;
            else if (StrEmployee.EmployeeStatus < 1 || StrEmployee.EmployeeStatus > 3)
                return true;


            return false;


        }
        public static bool IsValidInput(MEmployee StrEmployee)
        {
            if (StrEmployee.CreateByUserID >= 1) 
                return true;
            else if (StrEmployee.DepartmentID >= 1)
                return true;
            else if (StrEmployee.PersonID >= 1)
                return true;
            else if (StrEmployee.JobTitleID >=1)
                return true;
            else if (StrEmployee.EmployeeSalary >= 1)
                return true;


            return false;

        }

        public static (bool, string) IsAllRequirementsPass(MEmployee employee)
        {

            string TextInfo = "";
            bool IsValid = false;

            if (employee.EmployeeID != null && employee.EmployeeID <= 0)
            {

            }
            if (employee.PersonID != null && employee.PersonID <= 0)
            {


            }
            if (employee.ManagerID != null && employee.ManagerID <= 0)
            {


            }

            if (employee.DepartmentID != null && employee.DepartmentID <= 0)
            {


            }

            if (employee.CreateByUserID != null && employee.CreateByUserID <= 0)
            {


            }
            if (employee.EmployeeSalary != null && employee.EmployeeSalary <= 0)
            {


            }
            if (employee.HireDate != null)
            {


            }
            if (employee.EmployeeStatus != null && employee.EmployeeStatus <= 0)
            {


            }

            return (false, "");


        }

    }
   
    internal class MUserValidations
    {

        public static bool IsInputNULL(MUser StrUser, eMode mode)
        {

            if (StrUser.UserID == null && mode == eMode.Update)
                return true;
            else if (StrUser.Username == null)
                return true;
            else if (StrUser.Password == null)
                return true;
            else if (StrUser.IsActive == null)
                return true;
            else if (StrUser.EmployeeID == null)
                return true;


                return false;
        }

    }


}
