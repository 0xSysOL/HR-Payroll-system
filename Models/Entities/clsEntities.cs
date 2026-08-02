using System;

namespace Models.Entities
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ForParametersAttribute : Attribute
    {
        public string ParameterNameInSQL { get; }

        public ForParametersAttribute(string ParameterNameInSQL)
        {
            this.ParameterNameInSQL = ParameterNameInSQL;
        }
    }

    public class MApplicationLogAction
    {

        [ForParametersAttribute("Action ID")]
        public int? Action_ID { get; set; }

        [ForParametersAttribute("Application ID")]
        public int? Application_ID { get; set; }

        [ForParametersAttribute("User ID")]
        public int? User_ID { get; set; }

        [ForParametersAttribute("Action Date")]
        public DateTime? ActionDate { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [ForParametersAttribute("Application Status")]
        public byte? ApplicationStatus { get; set; }
    }

    public class MApplicationType
    {

        [ForParametersAttribute("App Type ID")]
        public  int? AppType_ID { get; set; }

        [ForParametersAttribute("Title")]
        public string? Title { get; set; }
    }

    public class MApplication
    {

        [ForParametersAttribute("Application ID")]
        public int? Application_ID { get; set; }

        [ForParametersAttribute("Date")]
        public DateTime? Date { get; set; }

        [ForParametersAttribute("Last Status Date")]
        public DateTime? LastStatusDate { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [ForParametersAttribute("Status")]
        public byte? Status { get; set; }

        [ForParametersAttribute("App Type ID")]
        public int? AppType_ID { get; set; }

        [ForParametersAttribute("Create By User ID")]
        public int? CreateByUser_ID { get; set; }

        [ForParametersAttribute("Employee ID")]
        public int? Employee_ID { get; set; }
    }

    public class MAttendance
    {

        [ForParametersAttribute("Attendance ID")]
        public int? Attendance_ID { get; set; }

        [ForParametersAttribute("Attendance Date")]
        public DateTime?  Attendance_Date { get; set; }

        [ForParametersAttribute("Check In Time")]
        public DateTime? CheckInTime { get; set; }

        [ForParametersAttribute("Check Out Time")]
        public DateTime? CheckOutTime { get; set; }

        [ForParametersAttribute("Employee ID")]
        public int? Employee_ID { get; set; }
    }

    public class MCountry
    {

        [ForParametersAttribute("Country ID")]
        public int? Country_ID { get; set; }

        [ForParametersAttribute("Country Name")]
        public string? CountryName { get; set; }
    }

    public class MDepartment
    {

        [ForParametersAttribute("DepartmentID")]
        public int? Department_ID { get; set; }

        [ForParametersAttribute("DepartmentName")]
        public string? Department_Name { get; set; }
    }

    public class MEmployee
    {

        [ForParametersAttribute("Employee ID")]
        public int Employee_ID { get; set; }

        [ForParametersAttribute("Person ID")]
        public int? Person_ID { get; set; }

        [ForParametersAttribute("Manager ID")]
        public int? Manager_ID { get; set; }

        [ForParametersAttribute("Department ID")]
        public int? Department_ID { get; set; }

        [ForParametersAttribute("Create By User ID")]
        public int? CreateByUser_ID { get; set; }

        [ForParametersAttribute("Salary")]
        public decimal? Salary { get; set; }

        /// <summary>
        /// 1 = Active. 2 = Suspended. 3 = Terminated.
        /// </summary>
        [ForParametersAttribute("Status")]
        public byte? Status { get; set; }

        [ForParametersAttribute("Hire Date")]
        public DateTime? HireDate { get; set; }
    }

    public class MMonthly_Payroll
    {

        [ForParametersAttribute("Monthly Payroll ID")]
        public int? M_Payroll_ID { get; set; }

        [ForParametersAttribute("Base Salary")]
        public decimal? Base_Salary { get; set; }

        [ForParametersAttribute("Salary Deduction")]
        public decimal? Salary_Deduction { get; set; }

        [ForParametersAttribute("Net Salary")]
        public decimal? Net_Salary { get; set; }

        [ForParametersAttribute("Create Date")]
        public DateTime? Create_Date { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [ForParametersAttribute("Status")]
        public byte? Status { get; set; }

        [ForParametersAttribute("Report ID")]
        public int? Report_ID { get; set; }

        [ForParametersAttribute("Completed By User ID")]
        public int? CompletedByUser_ID { get; set; }

        [ForParametersAttribute("Employee ID")]
        public int? Employee_ID { get; set; }
    }

    public class MPayroll_Report
    {

        [ForParametersAttribute("Payroll Report ID")]
        public int? PayrollR_ID { get; set; }

        [ForParametersAttribute("Financial Date")]
        public DateTime? Financial_Date { get; set; }

        [ForParametersAttribute("Date Of Create Report")]
        public DateTime? DateOfCreateReport { get; set; }

        [ForParametersAttribute("Create By User ID")]
        public int? CreateByUserID { get; set; }
    }

    public class MPeople
    {

        [ForParametersAttribute("PersonID")]
        public int? Person_ID { get; set; }

        [ForParametersAttribute("NationalNo")]
        public string? NationalNo { get; set; }

        [ForParametersAttribute("FirstName")]
        public string? FirstName { get; set; }

        [ForParametersAttribute("SecondName")]
        public string? SecondName { get; set; }

        [ForParametersAttribute("ThirdName")]
        public string? ThirdName { get; set; }

        [ForParametersAttribute("LastName")]
        public string? LastName { get; set; }

        [ForParametersAttribute("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [ForParametersAttribute("Gender")]
        public byte? Gender { get; set; }

        [ForParametersAttribute("Address")]
        public string? Address { get; set; }

        [ForParametersAttribute("PhoneNumber")]
        public string? Phone { get; set; }

        [ForParametersAttribute("Email")]
        public string? Email { get; set; }

        [ForParametersAttribute("ImagePath")]
        public string? ImagePath { get; set; }

        [ForParametersAttribute("CountryID")]
        public int? Country_ID { get; set; }
    }

    public class MTermination
    {

        [ForParametersAttribute("Termination ID")]
        public int? Termination_ID { get; set; }

        /// <summary>
        /// 1 = Resignation. 2 = Termination. 3 = Contract Expiration.
        /// </summary>
        [ForParametersAttribute("Termination Reason")]
        public byte? Termination_Reason { get; set; }

        [ForParametersAttribute("Termination Time")]
        public DateTime? Termination_Time { get; set; }

        [ForParametersAttribute("Description")]
        public string? Description { get; set; }

        [ForParametersAttribute("Employee ID")]
        public int? Employee_ID { get; set; }

        [ForParametersAttribute("Create By User ID")]
        public int? CreateByUser_ID { get; set; }
    }

    public class MUser
    {

        [ForParametersAttribute("User ID")]
        public int? User_ID { get; set; }

        [ForParametersAttribute("Username")]
        public string? Username { get; set; }

        [ForParametersAttribute("Password")]
        public string? Password { get; set; }

        /// <summary>
        /// 1 = Active.
        /// 0 = Not Active.
        /// </summary>
        [ForParametersAttribute("Is Active")]
        public bool? IsActive { get; set; }

        [ForParametersAttribute("Person ID")]
        public int? Person_ID { get; set; }
    }

    public class MVacation_Type
    {

        [ForParametersAttribute("VacationType ID")]
        public int? VacationType_ID { get; set; }

        [ForParametersAttribute("Title")]
        public string? Title { get; set; }

        [ForParametersAttribute("Days")]
        public byte? Days { get; set; }
    }

    public class MVacation
    {

        [ForParametersAttribute("Vacation ID")]
        public int? Vacation_ID { get; set; }

        [ForParametersAttribute("Begin Date")]
        public DateTime? BeginDate { get; set; }

        [ForParametersAttribute("End Date")]
        public DateTime?  EndDate { get; set; }

        [ForParametersAttribute("Actual Days")]
        public byte? ActualDays { get; set; }

        [ForParametersAttribute("Vacation Reason")]
        public string? VacationReason { get; set; }

        [ForParametersAttribute("Application ID")]
        public int? Application_ID { get; set; }

        [ForParametersAttribute("VacationType ID")]
        public int? VacationType_ID { get; set; }



    }
}