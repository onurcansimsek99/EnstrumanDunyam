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
    public class KullanicisController : ControllerBase
    {
        KullaniciManager _kullaniciService = new KullaniciManager();
        //private IKullaniciService _kullaniciService;

        //public KullanicisController()
        //{
        //    _kullaniciService = new KullaniciManager();
        //}

        [HttpGet]
        public List<Kullanici> GetAll()
        {
            return _kullaniciService.GetAll();
        }

        [HttpGet("get")]
        public Kullanici Get(int id)
        {
            return _kullaniciService.Get(id);
        }

        [HttpPost("add")]
        public IActionResult Add(Kullanici kullanici)
        {
            _kullaniciService.Add(kullanici);
            return Ok();
        }

        [HttpPost("update")]
        public void Update(Kullanici kullanici)
        {
            _kullaniciService.Update(kullanici);
        }

        [HttpPost("delete")]
        public void Delete(Kullanici kullanici)
        {
            _kullaniciService.Delete(kullanici);
        }
    }
}
