using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.DBContext;
using Data.Models;
using Microsoft.AspNetCore.Cors;

namespace PortfolioApi.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class InteractionsController : ControllerBase
    {
        private readonly PortfolioContext _context;

        public InteractionsController(PortfolioContext context)
        {
            _context = context;
        }

        #region GetInteractions
        [HttpGet("GetInteractions")]
        public async Task<ActionResult<IEnumerable<Interactions>>> GetInteractions()
        {
            return await _context.Interactions.ToListAsync();
        }
        #endregion

        #region GetInteraction
        [HttpGet("GetInteraction/{id}")]
        public async Task<ActionResult<Interactions>> GetInteraction(int id)
        {
            var interactions = await _context.Interactions.FindAsync(id);

            if (interactions == null)
            {
                return NotFound();
            }

            return interactions;
        }
        #endregion

        #region PutInteraction
        // PUT: api/Interactions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("PutInteraction/{id}")]
        public async Task<IActionResult> PutInteraction(int id, Interactions interactions)
        {
            if (id != interactions.Id)
            {
                return BadRequest();
            }

            _context.Entry(interactions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InteractionsExists(id))
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
        #endregion

        #region PostInteraction
        // POST: api/Interactions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostInteraction/{interactions}")]
        public async Task<ActionResult<Interactions>> PostInteraction(Interactions interactions)
        {
            _context.Interactions.Add(interactions);
            await _context.SaveChangesAsync();

            return Ok(interactions);
        }
        #endregion

        #region DeleteInteraction
        [HttpDelete("DeleteInteraction/{id}")]
        public async Task<IActionResult> DeleteInteraction(int id)
        {
            var interactions = await _context.Interactions.FindAsync(id);
            if (interactions == null)
            {
                return NotFound();
            }

            _context.Interactions.Remove(interactions);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        #endregion

        private bool InteractionsExists(int id)
        {
            return _context.Interactions.Any(e => e.Id == id);
        }
    }
}
