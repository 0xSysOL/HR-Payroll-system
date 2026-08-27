using Data_Layer.Entities;
using Microsoft.Data.SqlClient;
using Models.Entities;
using static Models.Enums.M_eColumnsName;
using static Models.Enums.M_Enums;

namespace Business___HR.Entities
{
    public class clsUser_BL
    {
        private MUser StrUser;
        eMode mode;

        public string? Username { get => StrUser.Username ?? "Empty"; set => StrUser.Username = value; }
        public string GetIsActive() => StrUser.IsActive != null ? StrUser.IsActive == true ? "Yes" : "No" : "Empty";
        public void SetIsActive(bool IsActive) => StrUser.IsActive = IsActive;

        public int? PersonID
        {
            get => StrUser.PersonID != null ? StrUser.PersonID : -1;
            set => StrUser.PersonID = value;

        }
        public void SetPassword(string Password) => StrUser.Password = Utilities.Utilities.HashPassword(Password);

        public clsUser_BL()
        {
            StrUser = new MUser();
            mode = eMode.Add;
        }
        public clsUser_BL(int UserID)
        {
            StrUser = GetUser(UserID);
            if(StrUser != null)
            mode = eMode.Update;
        }

        public bool Save()
        {

            // Feat: Add Validation

            switch (mode)
            {

                case eMode.Add:

                    StrUser.UserID = clsUser_DL.Add(StrUser);
                    mode = (StrUser.UserID != null) ? eMode.Update : eMode.Add;
                    return StrUser.UserID != null;


                case eMode.Update:
                    return clsUser_DL.Update(StrUser);

            }

            return false;
        }

        public static List<MUser> SelectRecordsAndChooseColumns(eUser[] _eUser)
        {

            MUser Structure = new MUser();
            foreach (eUser item in _eUser)
            {
                switch (item)
                {
                    case eUser.UserID:
                        Structure.UserID = -1;
                        break;
                    case eUser.Username:
                        Structure.Username = "";
                        break;

                    case eUser.Password:
                        Structure.Password = "";
                        break;

                    case eUser.IsActive:
                        Structure.IsActive = false;
                        break;

                    case eUser.PersonID:
                        Structure.PersonID = -1;
                        break;

                    default:
                        break;
                }
            }
            return clsUser_DL.SelectRecordsAndChooseColumns(Structure);
        }

        public static List<MUser> SelectRecords(int PageNumber,int RowPerPage) 
        {


            return clsUser_DL.SelectRecords(PageNumber, RowPerPage);


        } 

        public static MUser? GetUser(int UserID)
        {

            if (clsUser_DL.IsUserIDExists(UserID))
                return clsUser_DL.GetUserByID(UserID);
            else
                return null;


        }

        public static bool IsUserIDExists(int UserID) => clsUser_DL.IsUserIDExists(UserID);
        public static bool Delete(int UserID)
        {
            if (!clsUser_DL.IsUserIDExists(UserID))
                return false;


            return clsUser_DL.DeleteUser(UserID);

        }

        public static bool IsUsernameExists(string Username) => clsUser_DL.IsUsernameExists(Username);


    }



}
