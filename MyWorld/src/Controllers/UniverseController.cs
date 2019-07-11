using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyWorld.Models;

namespace MyWorld.Controllers
{
    [Route("/")]
    [ApiController]
    public class UniverseController : Controller
    {
        private readonly UniverseDbContext _context;
        private readonly Universe originalUniverse = new Universe { 
            Name = "Universe", 
            Description = "Welcome To the project starting point! \n The Universe"
        };

        public UniverseController(UniverseDbContext context)
        {
            _context = context ?? throw new ArgumentNullException("Failed to initialize UniverseContext !");
        }

        // GET /
        [HttpGet]
        public async Task<ActionResult<string>> GetOriginalUniverse()
        {
            if(_context.UniverseItems.Count() == 0)
            {
                await _context.UniverseItems.AddAsync(originalUniverse);
                await _context.SaveChangesAsync();
            }
            var originalUniverseFromDB = await _context.UniverseItems.FindAsync((long)1);
            if( originalUniverseFromDB == null )
            {
                return "Not Found";
            }
            return originalUniverseFromDB.getInfo();
        }

    }
}