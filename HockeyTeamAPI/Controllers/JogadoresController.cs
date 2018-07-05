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
    [RoutePrefix("api/equipas")]
    public class JogadoresController : ApiController
    {
        private HockeyDB db = new HockeyDB();

        // GET: api/Equipas
        public IHttpActionResult GetEquipas()
        {
            var resultado = db.Equipas
                .Select(equipa => new
                {
                    equipa.ID,
                    equipa.Nome,
                    equipa.Logotipo,
                    equipa.Plantel

                })
                .ToList();
            return Ok(resultado);
        }

        // GET: api/Equipas/5
        [ResponseType(typeof(Equipas))]
        public IHttpActionResult GetEquipas(int id)
        {
            Equipas equipas = db.Equipas.Find(id);
            if (equipas == null)
            {
                return NotFound();
            }
            var resultado = new
            {
                equipas.ID,
                equipas.Nome,
                equipas.Logotipo,
                equipas.Plantel

            };

            return Ok(resultado);
        }

        // GET: api/Equipas/Plantel
        [HttpGet, Route("plantel")]
        public IHttpActionResult GetPlantel()
        {
            var resultado = db.Equipas.Select(
                img => img.Plantel
            ).ToList();

            return Ok(resultado);
        }

        // PUT: api/Jogadores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutJogadores(int id, Jogadores jogadores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jogadores.ID)
            {
                return BadRequest();
            }

            db.Entry(jogadores).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JogadoresExists(id))
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

        // POST: api/Jogadores
        [ResponseType(typeof(Jogadores))]
        public IHttpActionResult PostJogadores(Jogadores jogadores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Jogadores.Add(jogadores);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = jogadores.ID }, jogadores);
        }

        // DELETE: api/Jogadores/5
        [ResponseType(typeof(Jogadores))]
        public IHttpActionResult DeleteJogadores(int id)
        {
            Jogadores jogadores = db.Jogadores.Find(id);
            if (jogadores == null)
            {
                return NotFound();
            }

            db.Jogadores.Remove(jogadores);
            db.SaveChanges();

            return Ok(jogadores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JogadoresExists(int id)
        {
            return db.Jogadores.Count(e => e.ID == id) > 0;
        }
    }
}