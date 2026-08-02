using Data_Layer.Entities;
using Models.Entities;
using Models.Enums;
using System.Data;
using static Business___HR.Utilities.Utilities;
using static Models.Enums.M_Enums;
namespace Business___HR.Entities
{
    public class clsPeople_BL
    {

        public MPeople StrPerson;



        eMode mode;
        public clsPeople_BL(MPeople people)
        {

            this.StrPerson = people;
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
            bool Resutl = false;

            switch (mode)
            {
                case eMode.Add:
                    // Feat: In Future We Can Call Event To Send ID
                    StrPerson.Person_ID = clsPeople_DL.Add(StrPerson);
                    Resutl = StrPerson.Person_ID != null ? true : false;
                    mode = Resutl != false ? eMode.Update : eMode.Add;
                    break;

                case eMode.Update:
                    return clsPeople_DL.Update(StrPerson);



            }
            return Resutl;

        }


        public static DataTable GetAll()
        {
            return clsPeople_DL.GetAll();
        }


        public static DataTable SelectRecords(M_eColumnsName.ePeople[] People)
        {

            MPeople Structure = new MPeople();
            foreach (M_eColumnsName.ePeople item in People)
            {
                switch (item)
                {
                    case M_eColumnsName.ePeople.PersonID:
                        Structure.Person_ID = -1;
                        break;

                    case M_eColumnsName.ePeople.NationalNo:
                        Structure.NationalNo = "";
                        break;

                    case M_eColumnsName.ePeople.FirstName:
                        Structure.FirstName = "";
                        break;

                    case M_eColumnsName.ePeople.SecondName:
                        Structure.SecondName = "";
                        break;

                    case M_eColumnsName.ePeople.ThirdName:
                        Structure.ThirdName = "";
                        break;

                    case M_eColumnsName.ePeople.LastName:
                        Structure.LastName = "";
                        break;

                    case M_eColumnsName.ePeople.DateOfBirth:
                        Structure.DateOfBirth = new DateTime();
                        break;

                    case M_eColumnsName.ePeople.PhoneNumber:
                        Structure.Phone = "";
                        break;

                    case M_eColumnsName.ePeople.Email:
                        Structure.Email = "";
                        break;

                    case M_eColumnsName.ePeople.ImagePath:
                        Structure.ImagePath = "";
                        break;

                    case M_eColumnsName.ePeople.CountryID:
                        Structure.Country_ID = -1;
                        break;

                    case M_eColumnsName.ePeople.Address:
                        Structure.Address = "";
                        break;
                    default:
                        break;
                }
            }


            return clsPeople_DL.SelectRecords(Structure);
        }



        public static bool IsNationalNoExists(string NationalNo)
        {




            return clsPeople_DL.IsNationalNoExists(NationalNo);

        }


        public static MPeople GetPersonByID(int PersonID)
        {





            DataTable data = clsPeople_DL.GetPersonByID(PersonID);

            if (data != null)
                return ConvertDataTableToMPeople(data);
            else
                return null;



        }

        // Update done



        // Delete


        public bool Delete(int PersonID)
        {

            // Feat: Add Validation Is Person ID Exists

            return clsPeople_DL.Delete(PersonID);
        }

    }


}
