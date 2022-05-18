#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetTypeController : ControllerBase
    {
        private readonly NumNumsContext _context;

        public PetTypeController(NumNumsContext context)
        {
            _context = context;
        }

        // GET: api/PetType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PetType>>> GetPetTypes()
        {
            return await _context.PetTypes.ToListAsync();
        }

        // GET: api/PetType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PetType>> GetPetType(string id)
        {
            var petType = await _context.PetTypes.FindAsync(id);

            if (petType == null)
            {
                return NotFound();
            }

            return petType;
        }

        // PUT: api/PetType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPetType(string id, PetType petType)
        {
            if (id != petType.PetTypeId)
            {
                return BadRequest();
            }

            _context.Entry(petType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PetType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PetType>> PostPetType(PetType petType)
        {
            _context.PetTypes.Add(petType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PetTypeExists(petType.PetTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }


            return CreatedAtAction("GetPetType", new { id = petType.PetTypeId }, petType);
        }

        // DELETE: api/PetType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePetType(string id)
        {
            var petType = await _context.PetTypes.FindAsync(id);
            if (petType == null)
            {
                return NotFound();
            }

            _context.PetTypes.Remove(petType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PetTypeExists(string id)
        {
            return _context.PetTypes.Any(e => e.PetTypeId == id);
        }
    }
}
