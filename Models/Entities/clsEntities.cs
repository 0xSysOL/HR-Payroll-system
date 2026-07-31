using System;

namespace Models.Entities
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MyAttribute : Attribute
    {
        public string RealNameColumn { get; }

        public MyAttribute(string realNameColumn)
        {
            RealNameColumn = realNameColumn;
        }
    }

    public class MApplicationLogAction
    {

        [MyAttribute("Action ID")]
        public int? Action_ID { get; set; }

        [MyAttribute("Application ID")]
        public int? Application_ID { get; set; }

        [MyAttribute("User ID")]
        public int? User_ID { get; set; }

        [MyAttribute("Action Date")]
        public DateTime? ActionDate { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [MyAttribute("Application Status")]
        public byte? ApplicationStatus { get; set; }
    }

    public class MApplicationType
    {

        [MyAttribute("App Type ID")]
        public  int? AppType_ID { get; set; }

        [MyAttribute("Title")]
        public string? Title { get; set; }
    }

    public class MApplication
    {

        [MyAttribute("Application ID")]
        public int? Application_ID { get; set; }

        [MyAttribute("Date")]
        public DateTime? Date { get; set; }

        [MyAttribute("Last Status Date")]
        public DateTime? LastStatusDate { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [MyAttribute("Status")]
        public byte? Status { get; set; }

        [MyAttribute("App Type ID")]
        public int? AppType_ID { get; set; }

        [MyAttribute("Create By User ID")]
        public int? CreateByUser_ID { get; set; }

        [MyAttribute("Employee ID")]
        public int? Employee_ID { get; set; }
    }

    public class MAttendance
    {

        [MyAttribute("Attendance ID")]
        public int? Attendance_ID { get; set; }

        [MyAttribute("Attendance Date")]
        public DateTime?  Attendance_Date { get; set; }

        [MyAttribute("Check In Time")]
        public DateTime? CheckInTime { get; set; }

        [MyAttribute("Check Out Time")]
        public DateTime? CheckOutTime { get; set; }

        [MyAttribute("Employee ID")]
        public int? Employee_ID { get; set; }
    }

    public class MCountry
    {

        [MyAttribute("Country ID")]
        public int? Country_ID { get; set; }

        [MyAttribute("Country Name")]
        public string? CountryName { get; set; }
    }

    public class MDepartment
    {

        [MyAttribute("DepartmentID")]
        public int? Department_ID { get; set; }

        [MyAttribute("DepartmentName")]
        public string? Department_Name { get; set; }
    }

    public class MEmployee
    {

        [MyAttribute("Employee ID")]
        public int Employee_ID { get; set; }

        [MyAttribute("Person ID")]
        public int? Person_ID { get; set; }

        [MyAttribute("Manager ID")]
        public int? Manager_ID { get; set; }

        [MyAttribute("Department ID")]
        public int? Department_ID { get; set; }

        [MyAttribute("Create By User ID")]
        public int? CreateByUser_ID { get; set; }

        [MyAttribute("Salary")]
        public decimal? Salary { get; set; }

        /// <summary>
        /// 1 = Active. 2 = Suspended. 3 = Terminated.
        /// </summary>
        [MyAttribute("Status")]
        public byte? Status { get; set; }

        [MyAttribute("Hire Date")]
        public DateTime? HireDate { get; set; }
    }

    public class MMonthly_Payroll
    {

        [MyAttribute("Monthly Payroll ID")]
        public int? M_Payroll_ID { get; set; }

        [MyAttribute("Base Salary")]
        public decimal? Base_Salary { get; set; }

        [MyAttribute("Salary Deduction")]
        public decimal? Salary_Deduction { get; set; }

        [MyAttribute("Net Salary")]
        public decimal? Net_Salary { get; set; }

        [MyAttribute("Create Date")]
        public DateTime? Create_Date { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [MyAttribute("Status")]
        public byte? Status { get; set; }

        [MyAttribute("Report ID")]
        public int? Report_ID { get; set; }

        [MyAttribute("Completed By User ID")]
        public int? CompletedByUser_ID { get; set; }

        [MyAttribute("Employee ID")]
        public int? Employee_ID { get; set; }
    }

    public class MPayroll_Report
    {

        [MyAttribute("Payroll Report ID")]
        public int? PayrollR_ID { get; set; }

        [MyAttribute("Financial Date")]
        public DateTime? Financial_Date { get; set; }

        [MyAttribute("Date Of Create Report")]
        public DateTime? DateOfCreateReport { get; set; }

        [MyAttribute("Create By User ID")]
        public int? CreateByUserID { get; set; }
    }

    public class MPeople
    {

        [MyAttribute("PersonID")]
        public int? Person_ID { get; set; }

        [MyAttribute("NationalNo")]
        public string? NationalNo { get; set; }

        [MyAttribute("FirstName")]
        public string? FirstName { get; set; }

        [MyAttribute("SecondName")]
        public string? SecondName { get; set; }

        [MyAttribute("ThirdName")]
        public string? ThirdName { get; set; }

        [MyAttribute("LastName")]
        public string? LastName { get; set; }

        [MyAttribute("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [MyAttribute("Gender")]
        public byte? Gender { get; set; }

        [MyAttribute("Address")]
        public string? Address { get; set; }

        [MyAttribute("PhoneNumber")]
        public string? Phone { get; set; }

        [MyAttribute("Email")]
        public string? Email { get; set; }

        [MyAttribute("ImagePath")]
        public string? ImagePath { get; set; }

        [MyAttribute("CountryID")]
        public int? Country_ID { get; set; }
    }

    public class MTermination
    {

        [MyAttribute("Termination ID")]
        public int? Termination_ID { get; set; }

        /// <summary>
        /// 1 = Resignation. 2 = Termination. 3 = Contract Expiration.
        /// </summary>
        [MyAttribute("Termination Reason")]
        public byte? Termination_Reason { get; set; }

        [MyAttribute("Termination Time")]
        public DateTime? Termination_Time { get; set; }

        [MyAttribute("Description")]
        public string? Description { get; set; }

        [MyAttribute("Employee ID")]
        public int? Employee_ID { get; set; }

        [MyAttribute("Create By User ID")]
        public int? CreateByUser_ID { get; set; }
    }

    public class MUser
    {

        [MyAttribute("User ID")]
        public int? User_ID { get; set; }

        [MyAttribute("Username")]
        public string? Username { get; set; }

        [MyAttribute("Password")]
        public string? Password { get; set; }

        /// <summary>
        /// 1 = Active.
        /// 0 = Not Active.
        /// </summary>
        [MyAttribute("Is Active")]
        public bool? IsActive { get; set; }

        [MyAttribute("Person ID")]
        public int? Person_ID { get; set; }
    }

    public class MVacation_Type
    {

        [MyAttribute("VacationType ID")]
        public int? VacationType_ID { get; set; }

        [MyAttribute("Title")]
        public string? Title { get; set; }

        [MyAttribute("Days")]
        public byte? Days { get; set; }
    }

    public class MVacation
    {

        [MyAttribute("Vacation ID")]
        public int? Vacation_ID { get; set; }

        [MyAttribute("Begin Date")]
        public DateTime? BeginDate { get; set; }

        [MyAttribute("End Date")]
        public DateTime?  EndDate { get; set; }

        [MyAttribute("Actual Days")]
        public byte? ActualDays { get; set; }

        [MyAttribute("Vacation Reason")]
        public string? VacationReason { get; set; }

        [MyAttribute("Application ID")]
        public int? Application_ID { get; set; }

        [MyAttribute("VacationType ID")]
        public int? VacationType_ID { get; set; }



    }
}