using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Services
{
    public class UserService
    {
        public bool ValidUserCredentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
