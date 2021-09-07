using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfBlogDal : IBlogDal
    {
        private Context _context = new Context();
        public void Add(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }

        public void Delete(int blogID)
        {
            _context.Blogs.Remove(_context.Blogs.FirstOrDefault(p => p.BlogID == blogID));
            _context.SaveChanges();
        }

        public Blog Get(int blogID)
        {
            return _context.Blogs.FirstOrDefault(p => p.BlogID == blogID);
        }

        public List<Blog> GetAll()
        {
            return _context.Blogs.ToList();
        }

        public void Update(Blog blog)
        {
            Blog blogToUpdate = _context.Blogs.FirstOrDefault(p => p.BlogID == blog.BlogID);
            blogToUpdate.BlogBaslik = blog.BlogBaslik;
            blogToUpdate.BlogIcerik = blog.BlogIcerik;
            blogToUpdate.BlogID = blog.BlogID;
            blogToUpdate.BlogYayinlanmaTarihi = blog.BlogYayinlanmaTarihi;
            blogToUpdate.BlogYazar = blog.BlogYazar;
            _context.SaveChanges();
        }
    }
}
