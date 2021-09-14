using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {

        EfBlogDal _blogDal = new EfBlogDal();

        // IBlogDal _blogDal;

        //public BlogManager()
        //{
        //}

        //public BlogManager(IBlogDal blogDal)
        //{
        //    _blogDal = blogDal;
        //}

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }
       


        public Blog Get(int blogID)
        {
            return _blogDal.Get(i=>i.BlogID==blogID);
        }

        public List<Blog> GetAll()
        {
            //var deneme = _blogDal.GetAll();
            return _blogDal.GetAll();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
