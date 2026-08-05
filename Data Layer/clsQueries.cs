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
            public static string GetAll = "GetAllPeople";
            public static string SelectRecords = "SelectRecords_People";
            public static string IsNationalNoExists = "IsNationalNoExists";
            public static string GetPersonIDByID = "GetPersonIDByID"; 
        }

        public class clsQUser
        {
            public static string Add = "AddUser";
            public static string Update = "UpdateUser";
            public static string DeleteUser = "deleteUser";
            public static string GetAll = "GetAllUser";
            public static string SelectRecords = "SelectRecords_User";
            public static string GetUser = "GetUser";
            public static string IsUserIDExists = "IsUserIDExists";
            public static string IsUsernameExists = "IsUsernameExists";


        }

    }
}
