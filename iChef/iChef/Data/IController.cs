using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Data
{
    public interface IController<T>
    {
        int Create(T entity);
        T Read();
        T ReadById(int id);
        int Update(T entity);
        int Delete(int id);
    }
}
