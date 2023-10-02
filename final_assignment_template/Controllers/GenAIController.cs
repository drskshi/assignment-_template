using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using final_assignment_template.Models;

namespace final_assignment_template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenAIController : ControllerBase
    {
        private readonly GenAIContext _context;

        public GenAIController(GenAIContext context)
        {
            _context = context;
        }

        // GET: api/GenAI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenAI>>> GetGenAIs()
        {
            return await _context.GenAIs.ToListAsync();
        }

        // GET: api/GenAI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GenAI>> GetGenAI(int id)
        {
            var genAI = await _context.GenAIs.FindAsync(id);

            if (genAI == null)
            {
                return NotFound();
            }

            return genAI;
        }

        // POST: api/GenAI
        [HttpPost]
        public async Task<ActionResult<GenAI>> PostGenAI(GenAI genAI)
        {
            _context.GenAIs.Add(genAI);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGenAI), new { id = genAI.Id }, genAI);
        }

        // PUT: api/GenAI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenAI(int id, GenAI genAI)
        {
            if (id != genAI.Id)
            {
                return BadRequest();
            }

            _context.Entry(genAI).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenAIExists(id))
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

        // DELETE: api/GenAI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenAI(int id)
        {
            var genAI = await _context.GenAIs.FindAsync(id);
            if (genAI == null)
            {
                return NotFound();
            }

            _context.GenAIs.Remove(genAI);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GenAIExists(int id)
        {
            return _context.GenAIs.Any(e => e.Id == id);
        }
    }
}
