﻿using BusinessLayer.Abstract;
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
        private IEnstrumanService _enstrumanService;

        public EnstrumansController()
        {
            _enstrumanService = new EnstrumanManager();
        }

        [HttpGet]
        public List<Enstruman> GetAll()
        {
            return _enstrumanService.GetAll();
        }

        [HttpGet("{enstrumanID}")]
        public Enstruman Get(int enstrumanID)
        {
            return _enstrumanService.Get(enstrumanID);
        }





    }
}
