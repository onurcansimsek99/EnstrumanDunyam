using DataAccessLayer.Abstract;
using EnstrumanDunyam.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {

        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(int blogID)
        {
            _blogDal.Delete(blogID);
        }

        public Blog Get(int blogID)
        {
            return _blogDal.Get(blogID);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
