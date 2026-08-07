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
        public static int? GetUserID() => CurrentUser.User_ID != null ? CurrentUser.User_ID : -1;
        public static void SetUserID(int UserID)  =>   CurrentUser.User_ID = UserID;
            
        
        
        
        public static string? GetUsername() => CurrentUser.Username != null ? CurrentUser.Username : "Username: Empty";
        public static void SetUsername(string Username) => CurrentUser.Username = Username;

        public static int? GetPersonID() => CurrentUser.Person_ID != null ? CurrentUser.Person_ID : -1;
        public static void SetPersonID(int PersonID) => CurrentUser.Person_ID = PersonID;

 

    }



}
