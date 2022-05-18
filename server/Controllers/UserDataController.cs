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
    public class UserDataController : ControllerBase
    {
        private readonly NumNumsContext _context;

        public UserDataController(NumNumsContext context)
        {
            _context = context;
        }

        // GET: api/UserData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserData>>> GetUserDatas()
        {
            return await _context.UserDatas.ToListAsync();
        }

        // GET: api/UserData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserData>> GetUserData(string id)
        {
            var userData = await _context.UserDatas.FindAsync(id);

            if (userData == null)
            {
                return NotFound();
            }

            return userData;
        }

        // PUT: api/UserData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserData(string id, UserData userData)
        {
            if (id != userData.UserDataId)
            {
                return BadRequest();
            }

            _context.Entry(userData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserDataExists(id))
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

        // POST: api/UserData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserData>> PostUserData(UserData userData)
        {
            _context.UserDatas.Add(userData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserDataExists(userData.UserDataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetUserData), new { id = userData.UserDataId }, userData);
            //return CreatedAtAction("GetUserData", new { id = userData.UserDataId }, userData);
        }

        // DELETE: api/UserData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserData(string id)
        {
            var userData = await _context.UserDatas.FindAsync(id);
            if (userData == null)
            {
                return NotFound();
            }

            _context.UserDatas.Remove(userData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserDataExists(string id)
        {
            return _context.UserDatas.Any(e => e.UserDataId == id);
        }
    }
}
