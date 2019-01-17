using Microsoft.AspNetCore.Mvc;
using MyWorld.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWorld.Controllers
{
    [Route("v1/[controller]")]
    public class UniverseController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Universe>), 200)]
        public Task<IActionResult> ReadAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}