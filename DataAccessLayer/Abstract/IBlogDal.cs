using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> GetAll();
        Blog Get(int blogID);
        void Add(Blog blog);
        //Deneme
        //Deneme2
        void Delete(int blogID);
        void Update(Blog blog);
    }
}
