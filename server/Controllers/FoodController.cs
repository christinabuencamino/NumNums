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
    public class FoodController : ControllerBase
    {
        private readonly NumNumsContext _context;

        public FoodController(NumNumsContext context)
        {
            _context = context;
        }

        // GET: api/Food
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Food>>> GetFoods()
        {
            return await _context.Foods.ToListAsync();
        }

        // GET: api/Food/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> GetFood(string id)
        {
            var food = await _context.Foods.FindAsync(id);

            if (food == null)
            {
                return NotFound();
            }

            return food;
        }

        // PUT: api/Food/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(string id, Food food)
        {
            if (id != food.FoodId)
            {
                return BadRequest();
            }

            _context.Entry(food).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodExists(id))
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

        // POST: api/Food
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Food>> PostFood(Food food)
        {
            _context.Foods.Add(food);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FoodExists(food.FoodId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFood", new { id = food.FoodId }, food);
        }

        // DELETE: api/Food/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(string id)
        {
            var food = await _context.Foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }

            _context.Foods.Remove(food);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodExists(string id)
        {
            return _context.Foods.Any(e => e.FoodId == id);
        }
    }
}
