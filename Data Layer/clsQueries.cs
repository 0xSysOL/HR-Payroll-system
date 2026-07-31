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
            public static string GetAll = "GetAllPeople";
            public static string SelectRecords = "SelectRecords_People";

        }


    }
}
