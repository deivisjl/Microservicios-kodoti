using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Service.Queries;
using Catalog.Service.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;

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
