using Business___HR.Entities;
using Models.Entities;
using Models.Enums;
using System.Data;
using System.Text;
namespace Hr___Payroll
{
    internal class Program
    {



        public static void TestCountryClass()
        {

            DataTable data = clsCountry_BL.GetAll();


            foreach(DataRow row in data.Rows)
            {

                Console.WriteLine(row["Country Name"]);

            }
        }
        public static void TestDepartment()
        {

            MDepartment department = new MDepartment();
            department.Department_Name = "Done";


            clsDepartment_BL clsDepartment_ = new clsDepartment_BL(department);

            Console.WriteLine(clsDepartment_.Add());

        }

        public static void TestPeople()
        {
            //MPeople people = new MPeople();

            //people.NationalNo = "19989876543210";
            //people.FirstName = "Fatima";
            //people.SecondName = "Hassan";
            //people.ThirdName = "Ibrahim";
            //people.LastName = "Al-Jubouri";
            //people.DateOfBirth = new DateTime(1998, 10, 20);
            //people.Gender = 0;
            //people.Address = "Erbil - Ankawa - 100 Meter Street";
            //people.Phone = "+9647509876543";
            //people.Email = "fatima.hassan@example.com";
            //people.ImagePath = "9876543210123";
            //people.Country_ID = 1;

            //clsPeople_BL clsPeople_BL = new clsPeople_BL(people);



            //clsPeople_BL.Save();



            //DataTable data = clsPeople_BL.GetAll();


            //foreach (DataRow row in data.Rows)
            //{

            //    Console.WriteLine(row["Person ID"]);

            //}


            M_eColumnsName.ePeople[] ePeople =
            {
                M_eColumnsName.ePeople.ImagePath,
                M_eColumnsName.ePeople.NationalNo
            };

            DataTable data =  clsPeople_BL.SelectRecords(ePeople);

            Console.OutputEncoding = Encoding.UTF8;
            foreach (DataRow row in data.Rows)
            {
                Console.WriteLine(row["Address"]);
                Console.WriteLine(row["FirstName"]);


            }


        }
        static void Main(string[] args)
        {


            TestPeople();
        }
    }
}
