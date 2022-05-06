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
    public class FoodPrefController : ControllerBase
    {
        private readonly NumNumsContext _context;

        public FoodPrefController(NumNumsContext context)
        {
            _context = context;
        }

        // GET: api/FoodPref
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodPref>>> GetFoodPref()
        {
            return await _context.FoodPref.ToListAsync();
        }

        // GET: api/FoodPref/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodPref>> GetFoodPref(string id)
        {
            var foodPref = await _context.FoodPref.FindAsync(id);

            if (foodPref == null)
            {
                return NotFound();
            }

            return foodPref;
        }

        // PUT: api/FoodPref/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodPref(string id, FoodPref foodPref)
        {
            if (id != foodPref.FoodPrefId)
            {
                return BadRequest();
            }

            _context.Entry(foodPref).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodPrefExists(id))
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

        // POST: api/FoodPref
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodPref>> PostFoodPref(FoodPref foodPref)
        {
            _context.FoodPref.Add(foodPref);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FoodPrefExists(foodPref.FoodPrefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFoodPref", new { id = foodPref.FoodPrefId }, foodPref);
        }

        // DELETE: api/FoodPref/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodPref(string id)
        {
            var foodPref = await _context.FoodPref.FindAsync(id);
            if (foodPref == null)
            {
                return NotFound();
            }

            _context.FoodPref.Remove(foodPref);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodPrefExists(string id)
        {
            return _context.FoodPref.Any(e => e.FoodPrefId == id);
        }
    }
}
