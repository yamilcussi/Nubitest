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
        /// <summary>
        /// Para esta funcion pude haber creado clases para interactuar
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[controller]")]
        
        public ActionResult<IEnumerable<NubiTest.Data.Users>> Get()
        {

            return Data.Models.Get.All(new Data.Users());

        }

    }
}