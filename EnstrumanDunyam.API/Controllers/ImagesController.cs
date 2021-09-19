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
    public class ImagesController : ControllerBase
    {
        ImageManager _imageManager = new ImageManager();

        [HttpPost("addImage")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] Image image, [FromForm(Name = ("imageID"))] int id)
        {
            _imageManager.Add(file, image, id);

            return Ok();
        }
    }
}
