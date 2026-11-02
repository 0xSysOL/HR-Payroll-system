namespace Models.Enums
{
    public class M_Enums
    {

        public enum eMode { Add, Update }
        public enum eApplicationStatus { New = 1, Canceled = 2, Completed = 3 }

    }


    public class M_eColumnsName
    {

        public enum ePerson
        {
            PersonID,
            NationalNo,
            FirstName,
            SecondName,
            ThirdName,
            LastName,
            DateOfBirth,
            PhoneNumber,
            Address,
            Email,
            ImagePath,
            CountryID
        }


        public enum eUser
        {
            UserID,
            Username,
            Password,
            IsActive,
            EmployeeID

        }


        public enum eEmployee
        {
            EmployeeID,
            PersonID,
            ManagerID,
            DepartmentID,
            CreateByUserID,
            EmployeeSalary,
            EmployeeStatus,
            HireDate

        }

    }


}
