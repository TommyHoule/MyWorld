using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

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
        public async Task<ActionResult<string>> GetOriginalUniverseInfo()
        {
            if(_context.UniverseItems.Count() == 0)
            {
                await PostUniverse(originalUniverse);
                await _context.SaveChangesAsync();
            }
            return await GetUniverseInfo((long)1);
        }

        // GET /8
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetUniverseInfo(long id)
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
        public async Task<ActionResult<Universe>> PostUniverse(Universe item)
        {
            await _context.UniverseItems.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUniverseInfo), new { id = item.Id }, item);
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, Universe item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}