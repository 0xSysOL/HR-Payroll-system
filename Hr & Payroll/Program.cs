using Business___HR.Entities;
using Models.Entities;
using System.Data;
using System.Diagnostics;
namespace Hr___Payroll
{
    internal class Program
    {



        public static void TestCountryClass()
        {

            List<MCountry> data = clsCountry_BL.GetData(1, 23);


            var id = data.Select(n => n.CountryID);

            Console.WriteLine(string.Join(",", id));
        }
        public static void TestDepartment()
        {

            MDepartment department = new MDepartment();
            department.DepartmentName = "Done";


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
            StrPerson.CountryID = 1;

            clsPeople_BL clsPeople_BL = new clsPeople_BL(StrPerson);



            clsPeople_BL.Save();



            //DataTable data = clsPeople_BL.GetData();


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


            //DataTable data = clsUser_BL.GetData();

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

        public static void TestEmployee()
        {
            //clsEmployee_BL Employee = new clsEmployee_BL();

            //Employee.StrEmployee.PersonID = 1;
            //Employee.StrEmployee.ManagerID = null;
            //Employee.StrEmployee.DepartmentID = 1;
            //Employee.StrEmployee.CreateByUserID = 10;
            //Employee.StrEmployee.Salary = 75000.00m;
            //Employee.StrEmployee.Status = 1;
            //Employee.StrEmployee.HireDate = new DateTime(2023, 6, 15);

            //if (Employee.Save())
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");


            //if(clsEmployee_BL.IsEmployeeExists(-1))
            //         Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            //clsEmployee_BL Employee = new clsEmployee_BL(6);

            //Employee.StrEmployee.Salary = 7000;

            //if (Employee.Save())
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");


            //Models.Enums.M_eColumnsName.eEmployee[] eEm = {
            //             M_eColumnsName.eEmployee.EmployeeID,
            //             M_eColumnsName.eEmployee.EmployeeSalary,
            //             M_eColumnsName.eEmployee.DepartmentID
            //};


            //clsEmployee_BL.SelectRecords(eEm);

            //clsEmployee_BL.Delete(6);
            clsEmployee_BL Employee = new clsEmployee_BL(7);

        }

        public static void TestApplication()
        {
            //clsApplication_BL App = new clsApplication_BL(10, M_Enums.eApplicationType.Canceled);


            ////App.StrApplication.Application_ID = 10;
            ////App.StrApplication.AppType_ID = 1;
            ////App.StrApplication.EmployeeID = 7;
            ////App.StrApplication.CreateByUserID = 10;

            //App.Save();
            //List<MApplication> ms = clsApplication_BL.SelectRecords(1, 3);
            //ms = clsApplication_BL.SelectRecords(1, 3);
            Stopwatch t1 = Stopwatch.StartNew();

            MApplication d = clsApplication_BL.GetApplicationByID(3);
            t1.Stop();
            Console.WriteLine("MS:"+t1.ElapsedMilliseconds);
            Stopwatch t2 = Stopwatch.StartNew();

            MApplication d2 = clsApplication_BL.GetApplicationByID(3);
            t2.Stop();
            Console.WriteLine("MS:" + t2.ElapsedMilliseconds);


        }
        static void Main(string[] args)
        {



            TestEmployee();


        }
    }
}
