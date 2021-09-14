using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnstrumanDunyam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        BlogManager _blogService = new BlogManager();
        //private IBlogService _blogService;

        //public BlogsController(BlogManager blogManager)
        //{
        //    _blogService = blogManager;
        //}

        [HttpGet]
        public List<Blog> GetAll()
        {
            return _blogService.GetAll();
        }

        [HttpGet("get")]
        public Blog Get(int id)
        {
            return _blogService.Get(id);
        }

        [HttpPost("add")]
        public IActionResult Add(Blog blog)
        {
            _blogService.Add(blog);
            return Ok();
        }

        [HttpPost("update")]                                 
        public void Update(Blog blog)
        {
            _blogService.Update(blog);
        }

        [HttpPost("delete")]
        public void Delete(Blog blog)
        {
            _blogService.Delete(blog);
        }
    }
}
