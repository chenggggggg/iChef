using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iChefWebApi.Models
{
    public class User
    {
        public int UserId { get; set; }

        public User(int userId)
        {
            UserId = userId;
        }
    }
}