using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Enums.M_Enums;
namespace Business___HR.Utilities
{
    internal  class Utilities
    {

        public static MPeople ConvertDataTableToMPeople(DataTable data)
        {
            MPeople Person = new MPeople();
            try
            {
                Person.Person_ID = (int)data.Rows[0]["PersonID"];
                Person.NationalNo = data.Rows[0]["NationalNo"].ToString();
                Person.FirstName = data.Rows[0]["FirstName"].ToString();
                Person.SecondName = data.Rows[0]["SecondName"].ToString();
                Person.ThirdName = data.Rows[0]["ThirdName"].ToString();
                Person.LastName = data.Rows[0]["LastName"].ToString();
                Person.DateOfBirth = (DateTime)data.Rows[0]["DateOfBirth"];
                Person.Gender = (byte)data.Rows[0]["Gender"];
                Person.Phone = data.Rows[0]["PhoneNumber"].ToString();
                Person.Address = data.Rows[0]["Address"].ToString();
                Person.Email = data.Rows[0]["Email"].ToString();
                Person.ImagePath = data.Rows[0]["ImagePath"].ToString();
                Person.Country_ID = (int)data.Rows[0]["CountryID"];
            }
            catch
            {
                Console.Write("Errore In Methode:" + "ConvertDataTableToMPeople");
                return null;
            }


            return Person;
        }

        public static MUser ConvertDataTableToMUser(DataTable data)
        {

            if (data == null)
                return null;


            MUser user = new MUser();

            try
            {
                user.User_ID = Convert.ToInt32(data.Rows[0]["UserID"]);
                user.Username = data.Rows[0]["Username"].ToString();
                user.Password = data.Rows[0]["Password"].ToString();
                user.IsActive = Convert.ToBoolean(data.Rows[0]["IsActive"]);
                user.Person_ID = Convert.ToInt32(data.Rows[0]["PersonID"]);
            }catch
            {
                Console.Write("Errore In Methode:" + "ConvertDataTableToMUser");
                return null;
            }


            return user;
        }

        public static  eMode ChangeModeToUpdate(eMode mode)
        {

            if (mode == eMode.Add)
                mode = eMode.Update;

            return mode;
        }

    }


}
