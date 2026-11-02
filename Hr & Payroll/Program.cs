using Business___HR.Entities;
using Business_Payroll.Entities;
using Models.Entities;
using Models.Enums;
using System.Diagnostics;
namespace Hr___Payroll
{
    internal class Program
    {



        public static void TestCountryClass()
        {

            List<MCountry> data = clsCountry_BL.GetData(1, 23);



            foreach (var item in data)
            {
                Console.WriteLine(item.CountryID);
                Console.WriteLine(item.CountryName);

            }

        }
        public static void TestDepartment()
        {

            MDepartment department = new MDepartment();
            department.DepartmentName = "Testing 2";


            clsDepartment_BL clsDepartment_ = new clsDepartment_BL(department);
            Console.WriteLine(clsDepartment_.Add());


        }

        public static void TestJobTitle()
        {
            clsJobTitle_BL clsJobTitle_BL = new Business___HR.Entities.clsJobTitle_BL("Testing 1");


            clsJobTitle_BL.Save();




        }
        public static void TestPeople()
        {
            MPeople StrPerson = new MPeople();

            //StrPerson.NationalNo = "19989876543210";
            //StrPerson.FirstName = "Fatima";
            //StrPerson.SecondName = "Hassan";
            //StrPerson.ThirdName = "Ibrahim";
            //StrPerson.LastName = "Al-Jubouri";
            //StrPerson.DateOfBirth = new DateTime(1998, 10, 20);
            //StrPerson.Gender = 0;
            //StrPerson.Address = "Erbil - Ankawa - 100 Meter Street";
            //StrPerson.PhoneNumber = "+9647509876543";
            //StrPerson.Email = "fatima.hassan@example.com";
            //StrPerson.ImagePath = "9876543210123";
            //StrPerson.CountryID = 1;

            //clsPeople_BL clsPeople_BL = new clsPeople_BL(StrPerson);



            //clsPeople_BL.Save();



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

            //List<MPeople> data = clsPeople_BL.SelectRowsAndChooseColumns(ePerson);

            //Console.OutputEncoding = Encoding.UTF8;
            //foreach (MPeople row in data)
            //{
            //    Console.WriteLine(row.PersonID);
            //    Console.WriteLine(row.FirstName);

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


            //clsPeople_BL clsPeople_DL = new clsPeople_BL(1);

            //List<MPeople> f = clsPeople_BL.SelectRecords(1, 4);



        }

        public static void TestUser()
        {



            clsUser_BL clsUser = new clsUser_BL();
            clsUser.Username = "User_6";
            clsUser.SetIsActive(true);
            clsUser.SetPassword("1235");
            clsUser.EmployeeID = 3;

            bool Re = clsUser.Save();


            //DataTable data = clsUser_BL.GetData();

            //foreach(DataRow row in data.Rows)
            //{

            //    Console.WriteLine(row["PersonID"]);
            //    Console.WriteLine(row["Username"]);

            //}



            //Models.Enums.M_eColumnsName.eUser[] eeUser =
            //    { Models.Enums.M_eColumnsName.eUser.Username};


            //List<MUser> data = clsUser_BL.SelectRecords(eeUser);

            //clsUser_BL clsUser_BL = new clsUser_BL(new MUser());

            //clsUser_BL.(1);

            //clsUser_BL.Delete(6);



            //bool i = clsUser_BL.IsUsernameExists("User1");





            //clsUser_BL user_BL = new clsUser_BL();


            //user_BL.SetPassword("1234");


            //List<MUser> d = clsUser_BL.SelectRecords(1, 4);


        }

        public static void TestEmployee()
        {

            MEmployee employee = new MEmployee();
            employee.PersonID = 2;
            employee.ManagerID = 1;
            employee.DepartmentID = 1;
            employee.CreateByUserID = 1;
            employee.EmployeeSalary = 55000.00m;
            employee.EmployeeStatus = 1;
            employee.JobTitleID = 1;

            employee.HireDate = new DateTime(2023, 6, 15);

            clsEmployee_BL Employee = new clsEmployee_BL(employee);
            if (Employee.Save())
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");


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

            ////clsEmployee_BL.Delete(6);
            //clsEmployee_BL Employee = new clsEmployee_BL();


            ////for (int i = 0; i < 3; i++)
            ////{
            ////    StartTime();
            ////    MEmployee mEmployee = clsEmployee_BL.SelectRecords(1, 2).First();
            ////    Console.WriteLine("Time MS: " + GetTimeMS());

            ////}
            //StartTime();
            //long Befor = GC.GetTotalMemory(true);
            //Console.WriteLine("Memory: " + Befor);
            //long After = 0;
            //Parallel.For(0, 20000, n =>
            //{

            //    clsEmployee_BL.SelectRecords(1, 5);
            //    clsApplication_BL.SelectRecords(1, 5);
            //    //M_eColumnsName.ePerson[] f = { M_eColumnsName.ePerson.Address };
            //    //clsPeople_BL.SelectRecords(f);
            //    clsPeople_DL.IsNationalNoExists("23");
            //});
            //Console.WriteLine("Time MS: " + GetTimeMS());
            //After = GC.GetTotalMemory(true);

            //Console.WriteLine("Memory: " + (After - Befor));

            ////M_eColumnsName.eEmployee[] eEmployees =
            ////    { M_eColumnsName.eEmployee.EmployeeID, M_eColumnsName.eEmployee.EmployeeSalary,M_eColumnsName.eEmployee.HireDate };

            ////mEmployee = clsEmployee_BL.SelectRowsAndChooseColumns(eEmployees).First();

        }

        public static void TestApplication()
        {
            //clsApplication_BL App = new clsApplication_BL(10, M_Enums.eApplicationStatus.Canceled);

            MApplication StrApplication = new MApplication();

            StrApplication.ApplicationTypeID = 1;
            StrApplication.CreateByUserID = 1;
            StrApplication.EmployeeID = 1;
            StrApplication.Date = DateTime.Now;

            clsApplication_BL App = new clsApplication_BL(StrApplication);



            //App.StrApplication.Application_ID = 10;
            //App.StrApplication.AppType_ID = 1;
            //App.StrApplication.EmployeeID = 7;
            //App.StrApplication.CreateByUserID = 10;

           Console.WriteLine("Result: "+App.Save());


            //List<MApplication> ms = clsApplication_BL.SelectRecords(1, 3);
            //ms = clsApplication_BL.SelectRecords(1, 3);


            //Stopwatch t1 = Stopwatch.StartNew();

            //MApplication d = clsApplication_BL.GetApplicationByID(3);
            //t1.Stop();
            //Console.WriteLine("MS:" + t1.ElapsedMilliseconds);
            //Stopwatch t2 = Stopwatch.StartNew();

            //MApplication d2 = clsApplication_BL.GetApplicationByID(3);
            //t2.Stop();
            //Console.WriteLine("MS:" + t2.ElapsedMilliseconds);


        }
      
        public static void TestTermination()
        {
            MTermination termination = new MTermination();

            termination.TerminationDate = DateTime.Now;
            termination.Description = "ff";
            termination.CreateByUserID = 1;
            termination.EmployeeID = 1;
            termination.TerminationReason = 1;

            clsTermination_BL termination_BL = new clsTermination_BL(termination);

            termination_BL.Add();

            Console.WriteLine("ID: " + termination.TerminationID);

        }
        public static void TestPayrollReports()
        {

            clsPayrollReport_BL payrollReport_BL = new clsPayrollReport_BL();

            payrollReport_BL.Add(DateTime.Now, 1);

        }

        public static void TestVacation()
        {
            Models.Entities.MVacation vacation = new MVacation();

            vacation.BeginDate = Convert.ToDateTime("2028/2/3");
            vacation.EndDate = Convert.ToDateTime("2028/2/6");
            vacation.VacationReason = "Test";
            vacation.ApplicationID = 1;
            vacation.VacationTypeID = 1;


            clsVacation_BL clsVacation = new clsVacation_BL(vacation);

            clsVacation.Add();


        }

        static Stopwatch t1 = Stopwatch.StartNew();
        public static void StartTime()
        {
            t1 = Stopwatch.StartNew();

            t1.Start();

        }
        public static long GetTimeMS()
        {
            t1.Stop();
            long MS = t1.ElapsedTicks;
            t1.Reset();
            return MS;
        }
        static void Main(string[] args)
        {
            //TestVacation(); In Queue
            //TestCountryClass();
            //TestDepartment();
            //TestPeople();
            //TestJobTitle();
            //TestUser();
            //TestEmployee();
            //TestApplication();
            //TestTermination();
            //TestPayrollReports();


            // Start Project
            Data_Layer.Errore_Catching.clsClient clsClient = new Data_Layer.Errore_Catching.clsClient();


            clsClient.Start();









            //ConcurrentDictionary<int, double> keyValuePairs = new ConcurrentDictionary<int, double>();
            //Parallel.For(0, 1, n =>
            //{
            //    StartTime();
            //    // here

            //    // here 
            //    double timeMs = (double)t1.ElapsedTicks / Stopwatch.Frequency * 1000.0;
            //    keyValuePairs.TryAdd(n, timeMs);
            //}
            //);
            //keyValuePairs.OrderBy(n => n);
            //var pairs = keyValuePairs.Select(n => new { n.Value, n.Key });


            //Console.WriteLine(keyValuePairs.Average(n => n.Value));


        }


    }
}
