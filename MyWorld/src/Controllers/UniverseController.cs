using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;

using MyWorld.Models;

namespace MyWorld.Controllers
{
    [Route("/")]
    [ApiController]
    public class UniverseController : Controller
    {
        private readonly UniverseDbContext _context;

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
                await _context.UniverseItems.AddAsync(new Universe { 
                    Name = "Universe", 
                    Description = "Welcome To the project starting point! \n The Universe"
                });
                await _context.SaveChangesAsync();
            }
            var originalUniverseFromDB = await _context.UniverseItems.FindAsync((long)1);
            if( originalUniverseFromDB == null )
            {
                return "Not Found";
            }
            return originalUniverseFromDB.getInfo();
        }

        //public async Task<ActionResult<Universe>> PostUniverse(Universe item)
        // POST /
        [HttpPost]
        public async Task<ActionResult<Universe>> PostUniverse(Universe universe)
        {
            _context.UniverseItems.Add(universe);
            
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOriginalUniverse), new { id = universe.Id }, universe);
        }

    }
}