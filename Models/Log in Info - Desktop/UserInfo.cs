using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Log_in_Info___Desktop
{
    public class UserInfo
    {

        private static MUser CurrentUser = new MUser();
        public static int? GetUserID() => CurrentUser.UserID != null ? CurrentUser.UserID : -1;
        public static void SetUserID(int UserID)  =>   CurrentUser.UserID = UserID;
            
        
        
        
        public static string? GetUsername() => CurrentUser.Username != null ? CurrentUser.Username : "Username: Empty";
        public static void SetUsername(string Username) => CurrentUser.Username = Username;

        public static int? GetPersonID() => CurrentUser.PersonID != null ? CurrentUser.PersonID : -1;
        public static void SetPersonID(int PersonID) => CurrentUser.PersonID = PersonID;

 

    }



}
