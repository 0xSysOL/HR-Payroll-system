using Data_Layer.Entities;
using Models.Entities;
using Models.Enums;
using System.Data;
using static Models.Enums.M_Enums;
using static Business___HR.Validations.MEmployeeValidations;
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


            return clsEmployee_DL.GetEmployeeByID(EmployeeID);

        }

        public bool Save()
        {
            // Feat: We Should Added Validation Important things one of them its Manager ID should not Give Him Null
            //if(IsAllRequirementsPass(employee))
            //{

            //}
            
            switch (_eMode)
            {

                case eMode.Add:
                    StrEmployee.EmployeeID = clsEmployee_DL.Add(StrEmployee);
                    return StrEmployee.EmployeeID != null ? true : false;
                        

                case eMode.Update:
                    return clsEmployee_DL.Update(StrEmployee);

            }

            return false;

        }

        public static bool IsEmployeeExists(int EmployeeID)
        {
            return clsEmployee_DL.IsEmployeeExists(EmployeeID);
        }


        public static List<MEmployee> SelectRowsAndChooseColumns(M_eColumnsName.eEmployee[] eEm)
        {
            if (Is_eEmployeeEmpty(eEm))
                return null;


            MEmployee Structure = new MEmployee();

            foreach (M_eColumnsName.eEmployee item in eEm)
            {
                switch (item)
                {
                    case M_eColumnsName.eEmployee.EmployeeID:
                        Structure.EmployeeID = -1;
                        break;

                    case M_eColumnsName.eEmployee.PersonID:
                        Structure.PersonID = -1;
                        break;

                    case M_eColumnsName.eEmployee.ManagerID:
                        Structure.ManagerID = -1;
                        break;

                    case M_eColumnsName.eEmployee.DepartmentID:
                        Structure.DepartmentID = -1;
                        break;

                    case M_eColumnsName.eEmployee.CreateByUserID:
                        Structure.CreateByUserID = -1;
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
                return clsEmployee_DL.SelectRecordsAndChooseColumns(Structure);
            else
                return null;

        }
        public static List<MEmployee> SelectRecords()
        {


            return clsEmployee_DL.SelectRecords();

        }
        public static bool Delete(int EmployeeID) 
        {
            return clsEmployee_DL.Delete(EmployeeID);
        }


    }



}
