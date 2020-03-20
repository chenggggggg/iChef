using iChef.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace iChef.Data
{
    public class UserDatabaseController : IController<User>
    {
        static object locker = new object();
        SQLiteConnection database;

        public UserDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
        }

        public int Create(User entity)
        {
            lock (locker)
            {
                if (entity.UserId != 0)
                {
                    return database.Insert(entity);
                }
                else
                {
                    return -1;
                }
            }
        }

        public User Read()
        {
            lock (locker)
            {
                if (database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<User>().First();
                }
            }
        }

        public User ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(User entity)
        {
            lock (locker)
            {
                if (entity.UserId != 0)
                {
                    return database.Update(entity);
                }
                else
                {
                    return -1;
                }
            }
        }

        public int Delete(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }
    }
}
