using Data_Layer.Entities;
using Models.Entities;
using static Models.Enums.M_Enums;
namespace Business___HR.Entities
{
    public class clsEmployee_BL
    {

        public MEmployee StrEmployee;
        eMode _eMode;
            

        public clsEmployee_BL()
        {
            StrEmployee = new MEmployee();
            _eMode = eMode.Add;
        }
        public clsEmployee_BL(int EmployeeID)
        {
            _eMode = eMode.Update;
            StrEmployee = GetEmployeeByID(EmployeeID);
        }

        public MEmployee GetEmployeeByID(int EmployeeID)
        {

            return Utilities.Utilities.ConvertDataTableToMEmployee(clsEmployee_DL.GetEmployeeByID(EmployeeID));

        }

        public bool Save()
        {
            // Feat: We Should Added Validation Important things one of them its Manager ID should not Give Him Null
            switch (_eMode)
            {

                case eMode.Add:
                    StrEmployee.Employee_ID = clsEmployee_DL.Add(StrEmployee);
                    return StrEmployee.Employee_ID != null ? true : false;


                case eMode.Update:
                    return clsEmployee_DL.Update(StrEmployee);

            }

            return false;

        }

        public static bool IsEmployeeExists(int EmployeeID)
        {

            return clsEmployee_DL.IsEmployeeExists(EmployeeID);
        }



    }



}
