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
            MPeople StrPerson = new MPeople();

            StrPerson.NationalNo = "19989876543210";
            StrPerson.FirstName = "Fatima";
            StrPerson.SecondName = "Hassan";
            StrPerson.ThirdName = "Ibrahim";
            StrPerson.LastName = "Al-Jubouri";
            StrPerson.DateOfBirth = new DateTime(1998, 10, 20);
            StrPerson.Gender = 0;
            StrPerson.Address = "Erbil - Ankawa - 100 Meter Street";
            StrPerson.Phone = "+9647509876543";
            StrPerson.Email = "fatima.hassan@example.com";
            StrPerson.ImagePath = "9876543210123";
            StrPerson.Country_ID = 1;

            clsPeople_BL clsPeople_BL = new clsPeople_BL(StrPerson);



            clsPeople_BL.Save();



            //DataTable data = clsPeople_BL.GetAll();


            //foreach (DataRow row in data.Rows)
            //{

            //    Console.WriteLine(row["StrPerson ID"]);

            //}


            //M_eColumnsName.ePerson[] ePerson =
            //{
            //    M_eColumnsName.ePerson.ImagePath,
            //    M_eColumnsName.ePerson.NationalNo,
            //    M_eColumnsName.ePerson.Address,
            //    M_eColumnsName.ePerson.FirstName
            //};

            //DataTable data =  clsPeople_BL.SelectRecords(ePerson);

            //Console.OutputEncoding = Encoding.UTF8;
            //foreach (DataRow row in data.Rows)
            //{
            //    Console.WriteLine(row["NationalNo"]);


            //}



            //MPeople d = new MPeople();
            //clsPeople_BL Person = new clsPeople_BL(d);

            //// Person.StrPerson.FirstName = "Nano";
            //// Person.StrPerson.SecondName = "Nano";
            //// Person.StrPerson.ThirdName = "N";
            //// Person.StrPerson.LastName = "Kh";
            //// Person.StrPerson.Address = "iraq";


            ////bool res =  Person.Save();

            //bool res=  Person.Delete(2);
        }

        public static void TestUser()
        {

            
         
            //clsUser_BL clsUser = new clsUser_BL();
            //clsUser.SetUsername("User1");
            //clsUser.SetIsActive(true);
            //clsUser.SetPassword("1234");
            //clsUser.SetPersonID(1);

            //bool Re = clsUser.Save();


            //DataTable data = clsUser_BL.GetAll();

            //foreach(DataRow row in data.Rows)
            //{

            //    Console.WriteLine(row["PersonID"]);
            //    Console.WriteLine(row["Username"]);

            //}



            //Models.Enums.M_eColumnsName.eUser[] eeUser =
            //    { Models.Enums.M_eColumnsName.eUser.IsActive};


            //DataTable data  = clsUser_BL.SelectRecords(eeUser);

            //clsUser_BL clsUser_BL = new clsUser_BL(new MUser());

            //clsUser_BL.(1);

            //clsUser_BL.Delete(6);



            //bool i = clsUser_BL.IsUsernameExists("User1");





            //clsUser_BL user_BL = new clsUser_BL();


            //user_BL.SetPassword("1234");

        }
        static void Main(string[] args)
        {

        



        }
    }
}
