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
        private readonly Universe originalUniverse = new Universe {
            Name = "Universe", 
            Description = "Welcome To the project starting point! \n The Universe"};

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
                await PostUniverse(originalUniverse);
                await _context.SaveChangesAsync();
            }
            return await GetUniverse((long)1);
        }

        // GET /8
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetUniverse(long id)
        {
            var UniverseFromDB = await _context.UniverseItems.FindAsync(id);
            if( UniverseFromDB == null )
            {
                return "Not Found";
            }
            return UniverseFromDB.getInfo();
            //will have to return direvtly a universe object
        }

        // POST /
        [HttpPost]
        public async Task<ActionResult<Universe>> PostUniverse(Universe universe)
        {
            await _context.UniverseItems.AddAsync(universe);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOriginalUniverse), new { id = universe.Id }, universe);
        }
    }
}