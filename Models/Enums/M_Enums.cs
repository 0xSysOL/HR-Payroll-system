namespace Models.Enums
{
    public class M_Enums
    {

        public enum eMode { Add, Update }


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
            PersonID

        }




    }


}
