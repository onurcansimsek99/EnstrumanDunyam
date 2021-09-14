using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        Context context = new Context();
        DbSet<T> _object;


        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Delete(T t)
        {
            var deletedEntity = context.Entry(t);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
            
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

       

        public void Update(T t)
        {
            var updatedEntity = context.Entry(t);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Add(T t)
        {
            var addedEntity = context.Entry(t);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }
}
