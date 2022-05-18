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
    public class PetGenderController : ControllerBase
    {
        private readonly NumNumsContext _context;

        public PetGenderController(NumNumsContext context)
        {
            _context = context;
        }

        // GET: api/PetGender
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PetGender>>> GetPetGender()
        {
            return await _context.PetGender.ToListAsync();
        }

        // GET: api/PetGender/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PetGender>> GetPetGender(string id)
        {
            var petGender = await _context.PetGender.FindAsync(id);

            if (petGender == null)
            {
                return NotFound();
            }

            return petGender;
        }

        // PUT: api/PetGender/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPetGender(string id, PetGender petGender)
        {
            if (id != petGender.PetGenderId)
            {
                return BadRequest();
            }

            _context.Entry(petGender).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetGenderExists(id))
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

        // POST: api/PetGender
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PetGender>> PostPetGender(PetGender petGender)
        {
            _context.PetGender.Add(petGender);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PetGenderExists(petGender.PetGenderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetPetGender), new { id = petGender.PetGenderId }, petGender);
            //return CreatedAtAction("GetPetGender", new { id = petGender.PetGenderId }, petGender);
        }

        // DELETE: api/PetGender/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePetGender(string id)
        {
            var petGender = await _context.PetGender.FindAsync(id);
            if (petGender == null)
            {
                return NotFound();
            }

            _context.PetGender.Remove(petGender);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PetGenderExists(string id)
        {
            return _context.PetGender.Any(e => e.PetGenderId == id);
        }
    }
}
