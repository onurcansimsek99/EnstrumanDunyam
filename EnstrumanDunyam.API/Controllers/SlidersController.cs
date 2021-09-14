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
    public class SlidersController : ControllerBase
    {
        SliderManager _sliderService = new SliderManager();
        //private ISliderService _sliderService;

        //public SlidersController()
        //{
        //    _sliderService = new SliderManager();
        //}

        [HttpGet]
        public List<Slider> GetAll()
        {
            return _sliderService.GetAll();
        }

        [HttpGet("get")]
        public Slider Get(int id)
        {
            return _sliderService.Get(id);
        }

        [HttpPost("add")]
        public IActionResult Add(Slider slider)
        {
            _sliderService.Add(slider);
            return Ok();
        }

        [HttpPost("update")]
        public void Update(Slider slider)
        {
            _sliderService.Update(slider);
        }

        [HttpPost("delete")]
        public void Delete(Slider slider)
        {
            _sliderService.Delete(slider);
        }
    }
}
