using iChef.DAL.Contexts;
using iChef.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace iChef.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        protected IContext<T> dataContext;

        public Repository(IContext<T> dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Delete(T Entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T Entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
