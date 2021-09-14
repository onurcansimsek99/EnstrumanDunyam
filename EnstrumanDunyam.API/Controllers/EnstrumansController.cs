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
    public class EnstrumansController : ControllerBase
    {
        EnstrumanManager _enstrumanService = new EnstrumanManager();
        //private IEnstrumanService _enstrumanService;

        //public EnstrumansController()
        //{
        //    _enstrumanService = new EnstrumanManager();
        //}

        [HttpGet]
        public List<Enstruman> GetAll()
        {
            return _enstrumanService.GetAll();
        }

        [HttpGet("get")]
        public Enstruman Get(int id)
        {
            return _enstrumanService.Get(id);
        }

        [HttpPost("add")]
        public IActionResult Add(Enstruman enstruman)
        {
            _enstrumanService.Add(enstruman);
            return Ok();
        }

        [HttpPost("update")]
        public void Update(Enstruman enstruman)
        {
            _enstrumanService.Update(enstruman);
        }

        [HttpPost("delete")]
        public void Delete(Enstruman enstruman)
        {
            _enstrumanService.Delete(enstruman);
        }





    }
}
