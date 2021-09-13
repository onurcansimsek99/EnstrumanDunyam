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
        private IBlogService _blogService;

        public BlogsController()
        {
            _blogService = new BlogManager();
        }

        [HttpGet]
        public List<Blog> GetAll()
        {
            return _blogService.GetAll();
        }

        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            return _blogService.Get(id);
        }
    }
}
