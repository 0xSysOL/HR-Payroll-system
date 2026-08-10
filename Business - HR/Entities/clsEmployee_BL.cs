using Data_Layer.Entities;
using Models.Entities;
using Models.Enums;
using System.Data;
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


        public static DataTable SelectRecords(M_eColumnsName.eEmployee[] eEm)
        {
            MEmployee Structure = new MEmployee();

            foreach (M_eColumnsName.eEmployee item in eEm)
            {
                switch (item)
                {
                    case M_eColumnsName.eEmployee.EmployeeID:
                        Structure.Employee_ID = -1;
                        break;

                    case M_eColumnsName.eEmployee.PersonID:
                        Structure.Person_ID = -1;
                        break;

                    case M_eColumnsName.eEmployee.ManagerID:
                        Structure.Manager_ID = -1;
                        break;

                    case M_eColumnsName.eEmployee.DepartmentID:
                        Structure.Department_ID = -1;
                        break;

                    case M_eColumnsName.eEmployee.CreateByUserID:
                        Structure.CreateByUser_ID = -1;
                        break;

                    case M_eColumnsName.eEmployee.EmployeeSalary:
                        Structure.Salary = 0;
                        break;

                    case M_eColumnsName.eEmployee.EmployeeStatus:
                        Structure.Status = 0;
                        break;

                    case M_eColumnsName.eEmployee.HireDate:
                        Structure.HireDate = DateTime.Now;
                        break;

                    default:
                        break;
                }
            }

            if (eEm.Length > 0)
                return clsEmployee_DL.SelectRecords(Structure);
            else
                return null;

        }

        public static bool Delete(int EmployeeID) 
        {
            return clsEmployee_DL.Delete(EmployeeID);
        }
    }



}
