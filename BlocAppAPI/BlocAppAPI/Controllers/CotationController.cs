using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlocAppAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlocAppAPI.Controllers
{
    [Route("api/Cotation")]
    [ApiController]
    public class CotationController : ControllerBase
    {
        private readonly BlocContext _context;
        public CotationController(BlocContext context)
        {
            _context = context;
        }

        // GET: api/Cotation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cotation>>> GetCotations()
        {
            return await _context.Cotations.ToListAsync();
        }

        // GET api/Cotation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cotation>> GetCotation(int id)
        {
            var bloc = await _context.Cotations.FindAsync(id);

            if (bloc == null)
            {
                return NotFound();
            }

            return bloc;
        }

        // POST api/Cotation
        [HttpPost]
        public async Task<ActionResult<Cotation>> PostCotation(Cotation bloc)
        {
            _context.Cotations.Add(bloc);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCotation), new { id = bloc.ID }, bloc);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCotation(int id, Cotation bloc)
        {
            if (id != bloc.ID)
            {
                return BadRequest();
            }

            _context.Entry(bloc).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var todoItem = await _context.Cotations.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Cotations.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
