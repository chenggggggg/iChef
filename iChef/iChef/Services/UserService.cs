using iChef.Data;
using iChef.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iChef.Services
{
    public class UserService
    {

        public UserService()
        {
        }


        /// <summary>
        /// Verifies if entered credentials are valid or filled in.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool VerifyUserCredentials(string username, string password)
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
