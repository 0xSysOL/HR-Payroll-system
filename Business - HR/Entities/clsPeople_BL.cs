using Data_Layer.Entities;
using Models.Entities;
using Models.Enums;
using static Models.Enums.M_Enums;
namespace Business___HR.Entities
{
    public class clsPeople_BL
    {

        public MPeople StrPerson;


        eMode mode;
        public clsPeople_BL(MPeople Person)
        {

            this.StrPerson = Person;
            mode = eMode.Add;
        }
        public clsPeople_BL(int PersonID)
        {

            StrPerson = GetPersonByID(PersonID);
            if (StrPerson != null)
                mode = eMode.Update;
        }

        public bool Save()
        {

            // Feat: Add Validation
            bool Resutl = false;

            switch (mode)
            {
                case eMode.Add:
                    // Feat: In Future We Can Call Event To Send ID
                    StrPerson.PersonID = clsPeople_DL.Add(StrPerson);
                    Resutl = StrPerson.PersonID != null ? true : false;
                    mode = Resutl != false ? eMode.Update : eMode.Add;
                    break;

                case eMode.Update:
                    return clsPeople_DL.Update(StrPerson);



            }
            return Resutl;

        }



        public static List<MPeople> SelectRowsAndChooseColumns(M_eColumnsName.ePerson[] People)
        {

            MPeople Structure = new MPeople();
            foreach (M_eColumnsName.ePerson item in People)
            {
                switch (item)
                {
                    case M_eColumnsName.ePerson.PersonID:
                        Structure.PersonID = -1;
                        break;

                    case M_eColumnsName.ePerson.NationalNo:
                        Structure.NationalNo = "";
                        break;

                    case M_eColumnsName.ePerson.FirstName:
                        Structure.FirstName = "";
                        break;

                    case M_eColumnsName.ePerson.SecondName:
                        Structure.SecondName = "";
                        break;

                    case M_eColumnsName.ePerson.ThirdName:
                        Structure.ThirdName = "";
                        break;

                    case M_eColumnsName.ePerson.LastName:
                        Structure.LastName = "";
                        break;

                    case M_eColumnsName.ePerson.DateOfBirth:
                        Structure.DateOfBirth = new DateTime();
                        break;

                    case M_eColumnsName.ePerson.PhoneNumber:
                        Structure.Phone = "";
                        break;

                    case M_eColumnsName.ePerson.Email:
                        Structure.Email = "";
                        break;

                    case M_eColumnsName.ePerson.ImagePath:
                        Structure.ImagePath = "";
                        break;

                    case M_eColumnsName.ePerson.CountryID:
                        Structure.CountryID = -1;
                        break;

                    case M_eColumnsName.ePerson.Address:
                        Structure.Address = "";
                        break;
                    default:
                        break;
                }
            }

            return clsPeople_DL.SelectRowsAndChooseColumns(Structure);
        }

        public static List<MPeople> SelectRecords(int PageNumber,int RowPerPage)
        {
            return clsPeople_DL.SelectRecords(PageNumber, RowPerPage);
        }

        public static bool IsNationalNoExists(string NationalNo)
        {

            return clsPeople_DL.IsNationalNoExists(NationalNo);

        }


        public static MPeople? GetPersonByID(int PersonID)
        {
            if(clsPeople_DL.IsPersonIDExists(PersonID))
            return clsPeople_DL.GetPersonByID(PersonID);

            return null;
        }



        public bool Delete(int PersonID)
        {

            // Feat: Add Validation Is Person ID Exists

            return clsPeople_DL.Delete(PersonID);
        }




    }


}
