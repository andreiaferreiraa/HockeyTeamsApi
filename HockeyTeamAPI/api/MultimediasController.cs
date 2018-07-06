using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HockeyTeamAPI.Models;

namespace HockeyTeamAPI.Controllers
{
    public class MultimediasController : ApiController
    {
        private HockeyDB db = new HockeyDB();

        // GET: api/Multimedias
        [Route("api/Multimedia")]
        public IHttpActionResult GetMultimedia()
        {
            var resultado = db.Multimedia
                .Select(multimedia => new
                {
                    multimedia.ID,
                    multimedia.NomeFotografia,
                    multimedia.JogadorPK
                })
                .ToList();

            return Ok(resultado);
        }

        // GET: api/Multimedias/5
        [Route("api/Multimedia/{id}")]
        public IHttpActionResult GetMultimedia(int id)
        {
            Multimedia multimedia = db.Multimedia.Find(id);
            if (multimedia == null)
            {
                return NotFound();
            }
            var resultado = new
            {
                multimedia.ID,
                multimedia.NomeFotografia,
                multimedia.JogadorPK

            };
            return Ok(resultado);
           
        }
        
        // PUT: api/Multimedias/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMultimedia(int id, Multimedia multimedia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != multimedia.ID)
            {
                return BadRequest();
            }

            db.Entry(multimedia).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MultimediaExists(id))
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

        // POST: api/Multimedias
        [ResponseType(typeof(Multimedia))]
        public IHttpActionResult PostMultimedia(Multimedia multimedia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Multimedia.Add(multimedia);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = multimedia.ID }, multimedia);
        }

        // DELETE: api/Multimedias/5
        [ResponseType(typeof(Multimedia))]
        public IHttpActionResult DeleteMultimedia(int id)
        {
            Multimedia multimedia = db.Multimedia.Find(id);
            if (multimedia == null)
            {
                return NotFound();
            }

            db.Multimedia.Remove(multimedia);
            db.SaveChanges();

            return Ok(multimedia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MultimediaExists(int id)
        {
            return db.Multimedia.Count(e => e.ID == id) > 0;
        }
    }
}