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
    public class PetController : ControllerBase
    {
        private readonly NumNumsContext _context;

        public PetController(NumNumsContext context)
        {
            _context = context;
        }

        // GET: api/Pet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PetData>>> GetPetDatas()
        {
            return await _context.PetDatas.ToListAsync();
        }

        // GET: api/Pet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PetData>> GetPetData(string id)
        {
            var petData = await _context.PetDatas.FindAsync(id);

            if (petData == null)
            {
                return NotFound();
            }

            return petData;
        }

        // PUT: api/Pet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPetData(string id, PetData petData)
        {
            if (id != petData.PetDataId)
            {
                return BadRequest();
            }

            _context.Entry(petData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetDataExists(id))
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

        // POST: api/Pet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PetData>> PostPetData(PetData petData)
        {
            _context.PetDatas.Add(petData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PetDataExists(petData.PetDataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPetData", new { id = petData.PetDataId }, petData);
        }

        // DELETE: api/Pet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePetData(string id)
        {
            var petData = await _context.PetDatas.FindAsync(id);
            if (petData == null)
            {
                return NotFound();
            }

            _context.PetDatas.Remove(petData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PetDataExists(string id)
        {
            return _context.PetDatas.Any(e => e.PetDataId == id);
        }
    }
}
