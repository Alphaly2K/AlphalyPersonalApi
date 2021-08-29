using System;
using System.Collections.Generic;
using System.Linq;
using AlphalyPersonalApi.Model;

namespace AlphalyPersonalApi.User
{
    public class UserLogin
    {
        private static string Email = "a@bc.d";
        private static string Password = "1234";
        public static bool Login(UserModel user)
        {
            if (user.Email == Email && user.Password == Password)
                return true;
            return false;
        }
    }
}
