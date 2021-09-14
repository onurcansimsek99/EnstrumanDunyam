using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
    }
}
