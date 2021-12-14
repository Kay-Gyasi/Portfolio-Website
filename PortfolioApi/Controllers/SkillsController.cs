using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.DBContext;

namespace PortfolioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly PortfolioContext _context;

        public SkillsController(PortfolioContext context)
        {
            _context = context;
        }

        #region GetSkills
        // GET: api/Skills
        [HttpGet("GetSkills")]
        public async Task<ActionResult<IEnumerable<Skills>>> GetSkills()
        {
            return await _context.Skills.ToListAsync();
        }
        #endregion

        #region GetSkill
        // GET: api/Skills/5
        [HttpGet("GetSkill/{id}")]
        public async Task<ActionResult<Skills>> GetSkill(int id)
        {
            var skills = await _context.Skills.FindAsync(id);

            if (skills == null)
            {
                return NotFound();
            }

            return skills;
        }
        #endregion

        #region PutSkill
        // PUT: api/Skills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("PutSkill/{id}")]
        public async Task<IActionResult> PutSkill(int id, Skills skills)
        {
            if (id != skills.Id)
            {
                return BadRequest();
            }

            _context.Entry(skills).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillExists(id))
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

        #region PostSkill
        // POST: api/Skills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostSkill")]
        public async Task<ActionResult<Skills>> PostSkill(Skills skills)
        {
            _context.Skills.Add(skills);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSkills", new { id = skills.Id }, skills);
        }
        #endregion

        #region DeleteSkill
        // DELETE: api/Skills/5
        [HttpDelete("DeleteSkill/{id}")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            var skills = await _context.Skills.FindAsync(id);
            if (skills == null)
            {
                return NotFound();
            }

            _context.Skills.Remove(skills);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        #endregion

        private bool SkillExists(int id)
        {
            return _context.Skills.Any(e => e.Id == id);
        }
    }
}
