using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Data
{
    public interface IController<T>
    {
        int Create(T entity);
        int Update(T entity);
        int Delete(int id);
        int Login(string username, string password);
    }
}
