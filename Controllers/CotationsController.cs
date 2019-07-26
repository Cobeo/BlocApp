using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BlocService.Models;

namespace BlocService.Controllers
{
    public class CotationsController : ApiController
    {
        private BlocServiceContext db = new BlocServiceContext();

        // GET: api/Cotations
        public IQueryable<Cotation> GetCotations()
        {
            return db.Cotations;
        }

        // GET: api/Cotations/5
        [ResponseType(typeof(Cotation))]
        public async Task<IHttpActionResult> GetCotation(int id)
        {
            Cotation cotation = await db.Cotations.FindAsync(id);
            if (cotation == null)
            {
                return NotFound();
            }

            return Ok(cotation);
        }

        // PUT: api/Cotations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCotation(int id, Cotation cotation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cotation.Id)
            {
                return BadRequest();
            }

            db.Entry(cotation).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CotationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Cotations
        [ResponseType(typeof(Cotation))]
        public async Task<IHttpActionResult> PostCotation(Cotation cotation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cotations.Add(cotation);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cotation.Id }, cotation);
        }

        // DELETE: api/Cotations/5
        [ResponseType(typeof(Cotation))]
        public async Task<IHttpActionResult> DeleteCotation(int id)
        {
            Cotation cotation = await db.Cotations.FindAsync(id);
            if (cotation == null)
            {
                return NotFound();
            }

            db.Cotations.Remove(cotation);
            await db.SaveChangesAsync();

            return Ok(cotation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CotationExists(int id)
        {
            return db.Cotations.Count(e => e.Id == id) > 0;
        }
    }
}