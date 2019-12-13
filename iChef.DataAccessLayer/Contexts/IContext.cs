using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.DAL.Contexts
{
    public interface IContext<T>
    {
        void Create(T entity);
        T Read(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
