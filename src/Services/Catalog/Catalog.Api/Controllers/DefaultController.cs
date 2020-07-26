using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers
{
    [Route("/")]
    public class DefaultController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}
