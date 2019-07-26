using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlocAppAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlocAppAPI.Controllers
{
    [Route("api/Bloc")]
    [ApiController]
    public class BlocController : ControllerBase
    {
        private readonly BlocContext _context;
        public BlocController(BlocContext context)
        {
            _context = context;
        }

        // GET: api/Bloc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bloc>>> GetBlocs()
        {
            return await _context.Blocs.ToListAsync();
        }

        // GET api/Bloc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bloc>> GetBloc(int id)
        {
            var bloc = await _context.Blocs.FindAsync(id);

            if (bloc == null)
            {
                return NotFound();
            }

            return bloc;
        }

        // POST api/Bloc
        [HttpPost]
        public async Task<ActionResult<Bloc>> PostBloc(Bloc bloc)
        {
            _context.Blocs.Add(bloc);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBloc), new { id = bloc.ID }, bloc);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloc(int id, Bloc bloc)
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
            var todoItem = await _context.Blocs.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Blocs.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
