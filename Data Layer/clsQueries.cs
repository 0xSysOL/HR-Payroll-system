using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    internal class clsQueries
    {


        public class clsQCountry
        {
            public static string GetAll = "GetAllCountries";


        }

        public class clsQDepartment
        {

            public static string Add = "AddDepartment";

        }
        public class clsQPeople
        {

            public static string Add = "AddPerson";
            public static string Update = "UpdatePerson";
            public static string Delete = "DeletePerson";
            public static string SelectRecords = "SelectRecords_People";
            public static string SelectRecordsAndChooseColumns = "SelectRecordsAndChooseColumns_People";
            public static string IsNationalNoExists = "IsNationalNoExists";
            public static string IsPersonIDExists = "IsPersonIDExists";
            public static string GetPersonIDByID = "GetPersonIDByID"; 

        }

        public class clsQUser
        {
            public static string Add = "AddUser";
            public static string Update = "UpdateUser";
            public static string DeleteUser = "deleteUser";
            public static string SelectRecordsAndChooseColumns = "SelectRecordsAndChooseColumns_Users";
            public static string SelectRecords = "SelectRecords_User";
            public static string GetUserByID = "GetUserByID";
            public static string IsUserIDExists = "IsUserIDExists";
            public static string IsUsernameExists = "IsUsernameExists";


        }
        public class clsQEmployee
        {

            public static string Add = "AddEmployee";
            public static string Update = "UpdateEmployee";
            public static string IsEmployeeExists = "IsEmployeeExists";
            public static string GetEmployeeByID = "GetEmployeeByID";
            public static string SelectRecordsAndChooseColumns = "SelectRecordsAndChooseColumns_Employee";
            public static string SelectRecords = "SelectRecords_Employee";

            public static string Delete = "DeleteEmployee";

        }


        public class clsQApplication
        {
            public static string Add = "AddNewApplication";
            public static string Update = "UpdateApplication";

            public static string SelectRecords = "SelectRecords_Applications";
            public static string GetApplicationByID = "GetApplicationByID";

        }

    }
}
