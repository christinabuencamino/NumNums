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
    public class LinkController : ControllerBase
    {
        private readonly NumNumsContext _context;

        public LinkController(NumNumsContext context)
        {
            _context = context;
        }

        // GET: api/Link
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebLink>>> GetLinks()
        {
            return await _context.Links.ToListAsync();
        }

        // GET: api/Link/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WebLink>> GetWebLink(string id)
        {
            var webLink = await _context.Links.FindAsync(id);

            if (webLink == null)
            {
                return NotFound();
            }

            return webLink;
        }

        // PUT: api/Link/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebLink(string id, WebLink webLink)
        {
            if (id != webLink.WebLinkId)
            {
                return BadRequest();
            }

            _context.Entry(webLink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebLinkExists(id))
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

        // POST: api/Link
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WebLink>> PostWebLink(WebLink webLink)
        {
            _context.Links.Add(webLink);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WebLinkExists(webLink.WebLinkId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetWebLink), new { id = webLink.WebLinkId }, webLink);
            //return CreatedAtAction("GetWebLink", new { id = webLink.WebLinkId }, webLink);
        }

        // DELETE: api/Link/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebLink(string id)
        {
            var webLink = await _context.Links.FindAsync(id);
            if (webLink == null)
            {
                return NotFound();
            }

            _context.Links.Remove(webLink);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WebLinkExists(string id)
        {
            return _context.Links.Any(e => e.WebLinkId == id);
        }
    }
}
