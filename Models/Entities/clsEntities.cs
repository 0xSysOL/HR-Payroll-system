using System;

namespace Models.Entities
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class DbColumnAttribute : Attribute
    {
        public string ColumnName { get; }
        public DbColumnAttribute(string ColumnName)
        {
            this.ColumnName = ColumnName;
        }
    }



    public class MApplicationLogAction
    {
        [DbColumnAttribute("ActionID")]
        public int? ActionID { get; set; }

        [DbColumnAttribute("ApplicationID")]
        public int? ApplicationID { get; set; }

        [DbColumnAttribute("UserID")]
        public int? UserID { get; set; }

        [DbColumnAttribute("ActionDate")]
        public DateTime? ActionDate { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [DbColumnAttribute("ApplicationStatus")]
        public byte? ApplicationStatus { get; set; }

        [DbColumnAttribute("ActionTriggerTypeID")]
        public int? ActionTriggerTypeID { get; set; }
    }

    public class MApplicationType
    {
        [DbColumnAttribute("ApplicationTypeID")]
        public int? ApplicationTypeID { get; set; }

        [DbColumnAttribute("Title")]
        public string? Title { get; set; }
    }

    public class MApplication
    {
        [DbColumnAttribute("ApplicationID")]
        public int? ApplicationID { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [DbColumnAttribute("Status")]
        public byte? Status { get; set; }

        [DbColumnAttribute("ApplicationTypeID")]
        public int? ApplicationTypeID { get; set; }

        [DbColumnAttribute("CreateByUserID")]
        public int? CreateByUserID { get; set; }

        [DbColumnAttribute("EmployeeID")]
        public int? EmployeeID { get; set; }
    }

    public class MAttendance
    {
        [DbColumnAttribute("AttendanceID")]
        public int? AttendanceID { get; set; }

        [DbColumnAttribute("AttendanceDate")]
        public DateTime? AttendanceDate { get; set; }

        [DbColumnAttribute("CheckInTime")]
        public DateTime? CheckInTime { get; set; }

        [DbColumnAttribute("CheckOutTime")]
        public DateTime? CheckOutTime { get; set; }

        [DbColumnAttribute("EmployeeID")]
        public int? EmployeeID { get; set; }
    }

    public class MCountry
    {
        [DbColumnAttribute("CountryID")]
        public int? CountryID { get; set; }

        [DbColumnAttribute("CountryName")]
        public string? CountryName { get; set; }
    }

    public class MDepartment
    {
        [DbColumnAttribute("DepartmentID")]
        public int? DepartmentID { get; set; }

        [DbColumnAttribute("DepartmentName")]
        public string? DepartmentName { get; set; }
    }

    public class MEmployee
    {
        [DbColumnAttribute("EmployeeID")]
        public int? EmployeeID { get; set; }

        [DbColumnAttribute("PersonID")]
        public int? PersonID { get; set; }

        [DbColumnAttribute("ManagerID")]
        public int? ManagerID { get; set; }

        [DbColumnAttribute("DepartmentID")]
        public int? DepartmentID { get; set; }

        [DbColumnAttribute("CreateByUserID")]
        public int? CreateByUserID { get; set; }

        [DbColumnAttribute("EmployeeSalary")]
        public decimal? Salary { get; set; }

        /// <summary>
        /// 1 = Active. 2 = Suspended. 3 = Terminated.
        /// </summary>
        [DbColumnAttribute("EmployeeStatus")]
        public byte? Status { get; set; }

        [DbColumnAttribute("HireDate")]
        public DateTime? HireDate { get; set; }
    }

    public class MMonthly_Payroll
    {
        [DbColumnAttribute("MonthlyPayrollID")]
        public int? MonthlyPayrollID { get; set; }

        [DbColumnAttribute("BaseSalary")]
        public decimal? BaseSalary { get; set; }

        [DbColumnAttribute("SalaryDeduction")]
        public decimal? SalaryDeduction { get; set; }

        [DbColumnAttribute("NetSalary")]
        public decimal? NetSalary { get; set; }

        [DbColumnAttribute("CreateDate")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 1 = New. 2 = Canceled. 3 = Completed
        /// </summary>
        [DbColumnAttribute("Status")]
        public byte? Status { get; set; }

        [DbColumnAttribute("ReportID")]
        public int? ReportID { get; set; }

        [DbColumnAttribute("CompletedByUserID")]
        public int? CompletedByUserID { get; set; }

        [DbColumnAttribute("EmployeeID")]
        public int? EmployeeID { get; set; }
    }

    public class MPayroll_Report
    {
        [DbColumnAttribute("PayrollReportID")]
        public int? PayrollReportID { get; set; }

        [DbColumnAttribute("FinancialDate")]
        public DateTime? FinancialDate { get; set; }

        [DbColumnAttribute("DateOfCreateReport")]
        public DateTime? DateOfCreateReport { get; set; }

        [DbColumnAttribute("CreateByUserID")]
        public int? CreateByUserID { get; set; }
    }

    public class MPeople
    {
        [DbColumnAttribute("PersonID")]
        public int? PersonID { get; set; }

        [DbColumnAttribute("NationalNo")]
        public string? NationalNo { get; set; }

        [DbColumnAttribute("FirstName")]
        public string? FirstName { get; set; }

        [DbColumnAttribute("SecondName")]
        public string? SecondName { get; set; }

        [DbColumnAttribute("ThirdName")]
        public string? ThirdName { get; set; }

        [DbColumnAttribute("LastName")]
        public string? LastName { get; set; }

        [DbColumnAttribute("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [DbColumnAttribute("Gender")]
        public byte? Gender { get; set; }

        [DbColumnAttribute("Address")]
        public string? Address { get; set; }

        [DbColumnAttribute("PhoneNumber")]
        public string? Phone { get; set; }

        [DbColumnAttribute("Email")]
        public string? Email { get; set; }

        [DbColumnAttribute("ImagePath")]
        public string? ImagePath { get; set; }

        [DbColumnAttribute("CountryID")]
        public int? CountryID { get; set; }
    }

    public class MTermination
    {
        [DbColumnAttribute("TerminationID")]
        public int? TerminationID { get; set; }

        /// <summary>
        /// 1 = Resignation. 2 = Termination. 3 = Contract Expiration.
        /// </summary>
        [DbColumnAttribute("TerminationReason")]
        public byte? TerminationReason { get; set; }

        [DbColumnAttribute("TerminationDate")]
        public DateTime? TerminationDate { get; set; }

        [DbColumnAttribute("Description")] 
        public string? Description { get; set; }

        [DbColumnAttribute("EmployeeID")]
        public int? EmployeeID { get; set; }

        [DbColumnAttribute("CreateByUserID")]
        public int? CreateByUserID { get; set; }
    }

    public class MUser
    {
        [DbColumnAttribute("UserID")]
        public int? UserID { get; set; }

        [DbColumnAttribute("Username")]
        public string? Username { get; set; }

        [DbColumnAttribute("Password")]
        public string? Password { get; set; }

        /// <summary>
        /// 1 = Active.
        /// 0 = Not Active.
        /// </summary>
        [DbColumnAttribute("IsActive")]
        public bool? IsActive { get; set; }

        [DbColumnAttribute("PersonID")]
        public int? PersonID { get; set; }
    }

    public class MVacation_Type
    {
        [DbColumnAttribute("VacationTypeID")]
        public int? VacationTypeID { get; set; }

        [DbColumnAttribute("Title")]
        public string? Title { get; set; }

        [DbColumnAttribute("Days")]
        public byte? Days { get; set; }
    }

    public class MVacation
    {
        [DbColumnAttribute("VacationID")]
        public int? VacationID { get; set; }

        [DbColumnAttribute("BeginDate")]
        public DateTime? BeginDate { get; set; }

        [DbColumnAttribute("EndDate")]
        public DateTime? EndDate { get; set; }

        [DbColumnAttribute("ActualDays")]
        public byte? ActualDays { get; set; }

        [DbColumnAttribute("VacationReason")]
        public string? VacationReason { get; set; }

        [DbColumnAttribute("ApplicationID")]
        public int? ApplicationID { get; set; }

        [DbColumnAttribute("VacationTypeID")]
        public int? VacationTypeID { get; set; }
    }



}