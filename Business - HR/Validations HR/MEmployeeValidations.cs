using Models.Entities;
using Models.Enums;

namespace Business___HR.Validations
{
    internal class MEmployeeValidations
    {


        public static bool IsEmpty(MEmployee employee) => employee == null;
        public static bool Is_eEmployeeEmpty(M_eColumnsName.eEmployee[] eEm) => eEm == null;

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
            if (employee.Salary != null && employee.Salary <= 0)
            {


            }
            if (employee.HireDate != null)
            {


            }
            if (employee.Status != null && employee.Status <= 0)
            {


            }

            return (false, "");


        }

    }

}
