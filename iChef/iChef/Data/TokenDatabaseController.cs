using iChef.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace iChef.Data
{
    public class TokenDatabaseController : IController<Token>
    {
        static object locker = new object();
        SQLiteConnection database;

        public TokenDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Token>();
        }

        public int Create(Token entity)
        {
            lock (locker)
            {
                if (entity.TokenId != 0)
                {
                    return database.Insert(entity);
                }
                else
                {
                    return -1;
                }
            }
        }

        public Token Read()
        {
            lock (locker)
            {
                if (database.Table<Token>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Token>().First();
                }
            }
        }
        public Token ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Token entity)
        {
            lock (locker)
            {
                if (entity.TokenId != 0)
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
                return database.Delete<Token>(id);
            }
        }
    }
}
