using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        // Context _context = new Context();
        //DbSet<Blog> _object;

        //public EfBlogDal()
        //{
        //    _object = _context.Set<Blog>();
        //}
        //public void Add(Blog blog)
        //{
        //    _context.Blogs.Add(blog);
        //    _context.SaveChanges();
        //}

        //public void Delete(int blogID)
        //{
        //    _context.Blogs.Remove(_context.Blogs.FirstOrDefault(p => p.BlogID == blogID));
        //    _context.SaveChanges();
        //}

        //public Blog Get(int blogID)
        //{
        //    return _context.Blogs.FirstOrDefault(p => p.BlogID == blogID);
        //}

        //public List<Blog> GetAll()
        //{
        //    return _object.ToList();
        //    //return _context.Blogs.ToList();
        //}

        //public void Update(Blog blog)
        //{
        //    Blog blogToUpdate = _context.Blogs.FirstOrDefault(p => p.BlogID == blog.BlogID);
        //    blogToUpdate.BlogBaslik = blog.BlogBaslik;
        //    blogToUpdate.BlogIcerik = blog.BlogIcerik;
        //    blogToUpdate.BlogYayinlanmaTarihi = blog.BlogYayinlanmaTarihi;
        //    blogToUpdate.BlogYazar = blog.BlogYazar;
        //    _context.SaveChanges();
        //}
      
    }
}
