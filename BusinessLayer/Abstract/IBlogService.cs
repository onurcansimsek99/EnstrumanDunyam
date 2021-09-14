using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        public List<Blog> GetAll();
        public Blog Get(int blogID);
        public void Add(Blog blog);
        public void Delete(Blog blog);
        public void Update(Blog blog);
    }
}
