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
    public class MarkasController : ControllerBase
    {
        MarkaManager _markaService = new MarkaManager();
        //private IMarkaService _markaService;

        //public MarkasController()
        //{
        //    _markaService = new MarkaManager();
        //}

        [HttpGet]
        public List<Marka> GetAll()
        {
            return _markaService.GetAll();
        }

        [HttpGet("get")]
        public Marka Get(int id)
        {
            return _markaService.Get(id);
        }

        [HttpPost("add")]
        public IActionResult Add(Marka marka)
        {
             _markaService.Add(marka);
            return Ok();
        }

        [HttpPost("update")]
        public void Update(Marka marka)
        {
            _markaService.Update(marka);
        }

        [HttpPost("delete")]
        public void Delete(Marka marka)
        {
            _markaService.Delete(marka);
        }
    }
}
