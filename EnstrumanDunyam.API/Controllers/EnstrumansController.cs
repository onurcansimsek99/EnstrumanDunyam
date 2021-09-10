using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EnstrumanDunyam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnstrumansController : ControllerBase
    {
        public List<Enstruman> Get()
        {
            return
        }
    }
}
