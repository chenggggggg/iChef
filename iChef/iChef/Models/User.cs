using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int userId)
        {
            UserId = userId;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
