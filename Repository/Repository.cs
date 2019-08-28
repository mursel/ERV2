using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public abstract class Repository<T> : IRepository<T> where T: class
    {
        private MainContext mainContext;

        public Repository(MainContext _mainContext) => this.mainContext = _mainContext;

        public void Create(T entity)
        {
            mainContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            mainContext.Set<T>().Remove(entity);
        }

        public System.Linq.IQueryable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return mainContext.Set<T>().Where(expression).AsNoTracking();
        }

        public System.Linq.IQueryable<T> GetAll()
        {
            return mainContext.Set<T>().AsNoTracking();
        }
        
        public void Update(T entity)
        {
            mainContext.Set<T>().Update(entity);
        }

    }
}
