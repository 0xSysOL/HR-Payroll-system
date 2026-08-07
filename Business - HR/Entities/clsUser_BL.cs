using Data_Layer.Entities;
using Models.Entities;
using Models.Enums;
using System.Data;
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
            get => StrUser.Person_ID != null ? StrUser.Person_ID : -1;
            set => StrUser.Person_ID = value;
        }
      
        public void SetPassword(string Password) => StrUser.Password = Utilities.Utilities.HashPassword(Password);



        public clsUser_BL()
        {
            StrUser = new MUser();
            mode = eMode.Add;
        }

        public bool Save()
        {

            // Feat: Add Validation

            switch (mode)
            {

                case eMode.Add:

                    StrUser.User_ID = clsUser_DL.Add(StrUser);
                    mode = (StrUser.User_ID != null) ? eMode.Update : eMode.Add;
                    return StrUser.User_ID != null;


                case eMode.Update:
                    return clsUser_DL.Update(StrUser);

            }

            return false;
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable GetAll() => clsUser_DL.GetAll();


        public static DataTable SelectRecords(eUser[] _eUser)
        {

            MUser Structure = new MUser();
            foreach (M_eColumnsName.eUser item in _eUser)
            {
                switch (item)
                {
                    case eUser.UserID:
                        Structure.User_ID = -1;
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
                        Structure.Person_ID = -1;
                        break;

                    default:
                        break;
                }
            }



            return clsUser_DL.SelectRecords(Structure);
        }

        public static MUser GetUser(int UserID)
        {
            DataTable data = clsUser_DL.GetUser(UserID);

            return Utilities.Utilities.ConvertDataTableToMUser(data);

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
