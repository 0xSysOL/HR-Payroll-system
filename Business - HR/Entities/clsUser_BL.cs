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
        public MUser StrUser;
        eMode mode;

        public clsUser_BL(MUser User)
        {
            StrUser = User;
            mode = eMode.Add;
        }

        public bool Save()
        {

            // Feat: Add Validation

            switch (mode)
            {

                case eMode.Add:
                    
                    StrUser.User_ID = clsUser_DL.Add(StrUser);
                    mode = (StrUser.Person_ID != null) ? eMode.Update : eMode.Add;
                    return StrUser.User_ID != null;


                case eMode.Update:

                    break;

            }

            return false;
        }
 
        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable  GetAll()
        {

            return clsUser_DL.GetAll();
        }

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


    }



}
