using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using OAD.Data;

namespace OAD.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SampleDataEntities _entity;

        public Repository(SampleDataEntities entity)
        {
            _entity = entity;
        }

        public List<T> GetAll()
        {
            return _entity.Set<T>().ToList();
        }

        public List<T> GetConditionalEntities(Expression<Func<T, bool>> predicate)
        {
            return _entity.Set<T>().Where(predicate).ToList();
        }

        public T Get(int id)
        {
            return _entity.Set<T>().Find(id);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _entity.Set<T>().FirstOrDefault(predicate);
        }

        public bool Insert(T entity)
        {
            _entity.Set<T>().Add(entity);
            return _entity.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            _entity.Set<T>().Attach(entity);
            _entity.Entry(entity).State = EntityState.Modified;

            return _entity.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            _entity.Set<T>().Attach(entity);
            _entity.Entry(entity).State = EntityState.Deleted;

            return _entity.SaveChanges() > 0;
        }
    }
}
