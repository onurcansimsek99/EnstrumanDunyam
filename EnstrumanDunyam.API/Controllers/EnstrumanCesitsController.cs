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
    public class EnstrumanCesitsController : ControllerBase
    {
        private IEnstrumanCesitService _enstrumanCesitService;

        public EnstrumanCesitsController()
        {
            _enstrumanCesitService = new EnstrumanCesitManager();
        }

        [HttpGet]
        public List<EnstrumanCesit> GetAll()
        {
            return _enstrumanCesitService.GetAll();
        }

        [HttpGet("{id}")]
        public EnstrumanCesit Get(int id)
        {
            return _enstrumanCesitService.Get(id);
        }
    }
}
