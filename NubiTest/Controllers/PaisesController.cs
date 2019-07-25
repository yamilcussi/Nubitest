using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NubiTest.MercadoLibre.Countries;

namespace NubiTest.Api.Controllers
{

    [ApiController]
    public class PaisesController : ControllerBase
    {
        /// <summary>
        /// Retrieves countries information
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]     
        [Route("[controller]/{id}")]
        public ActionResult<CountriesResponse> Get(string id)
        {
            if (!string.IsNullOrEmpty(id)&& id.ToUpper()!="AR") { return Unauthorized(); }
            return CountriesService.Get(id) ;
        }

       
    }
}
