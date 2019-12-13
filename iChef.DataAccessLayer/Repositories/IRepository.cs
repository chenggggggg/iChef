using System;
using System.Linq;
using System.Linq.Expressions;

namespace iChef.DAL.Repositories
{
    public interface IRepository<T>
    {
        void Insert(T Entity);
        void Delete(T Entity);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
