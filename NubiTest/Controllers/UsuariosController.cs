using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NubiTest.Api.Controllers
{
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]")]
        public ActionResult<IEnumerable<NubiTest.Data.Users>> Get()
        {
            NubiTest.Data.NubiDbContext db = new NubiTest.Data.NubiDbContext();
            return db.Users.ToList();

        }

    }
}