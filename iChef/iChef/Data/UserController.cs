using iChef.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Net.Http;
using System.Threading.Tasks;

namespace iChef.Data
{
    public class UserController : IController<User>
    {
        private static readonly object locker = new object();

        /// <summary>
        /// Insert a new user in to the database and returns the new users id or 0.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(User entity)
        {
            lock (locker)
            {
                
            }
            return 0;
        }

        public int Login(string username, string password)
        {
            int userId = 0;
            lock (locker)
            {

            }
            return userId;
        }

        public int Update(User entity)
        {
            lock (locker)
            {
                //To be added
                return 0;
            }
        }

        public int Delete(int id)
        {
            lock (locker)
            {
                //To be added
                return 0;
            }
        }
    }
}
