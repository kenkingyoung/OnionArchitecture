using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OAD.Repo
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetConditionalEntities(Expression<Func<T, bool>> predicate);
        T Get(int id);
        T Get(Expression<Func<T, bool>> predicate);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
