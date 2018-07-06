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
    
    public class JogadoresController : ApiController
    {
        private HockeyDB db = new HockeyDB();

        // GET: api/Jogadores
        [Route("api/Jogadores")]
        public IHttpActionResult GetJogadores()
        {
            var resultado = db.Jogadores
                .Select(jogadores => new
                {
                    jogadores.ID,
                    jogadores.EquipaPK,
                    jogadores.Nome,
                    jogadores.NomeCompleto,
                    jogadores.Número,
                    jogadores.Posicao,
                    jogadores.DataNascimento,
                    jogadores.Nacionalidade,
                    jogadores.Altura,
                    jogadores.Peso,
                    jogadores.Fotografia
                })
                .ToList();
            return Ok(resultado);
        }

        // GET: api/Jogadores/5
        [ResponseType(typeof(Equipas))]
        [Route("api/jogadores/{id}")]
        public IHttpActionResult GetEquipas(int id)
        {
            Jogadores jogadores = db.Jogadores.Find(id);
            if (jogadores == null)
            {
                return NotFound();
            }
            var dataNasc = jogadores.DataNascimento.ToString("dd/MM/yyyy");
            var resultado = new
            {
                jogadores.ID,
                jogadores.EquipaPK,
                jogadores.Nome,
                jogadores.NomeCompleto,
                jogadores.Número,
                jogadores.Posicao,
                dataNasc,
                jogadores.Nacionalidade,
                jogadores.Altura,
                jogadores.Peso,
                jogadores.Fotografia
            };
            return Ok(resultado);
        }

        //GET : api/Jogadores/1/Multimedia
        [Route("api/jogadores/{id}/multimedia")]
        public IHttpActionResult GetJogadoresEquipa(int id)
        {
            Jogadores jogadores = db.Jogadores.Find(id);
            if (jogadores == null)
            {
                return NotFound();
            }
            var multimedia = db.Multimedia.Where(j => j.JogadorPK == jogadores.ID).Select(r => new
            {
                r.NomeFotografia

            }).ToList();

            return Ok(multimedia);
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