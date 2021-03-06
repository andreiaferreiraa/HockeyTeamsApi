﻿using System;
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
    public class EquipasController : ApiController
    {
        
        private HockeyDB db = new HockeyDB();

        // GET: api/Equipas
        [Route("api/Equipas")]
        public IHttpActionResult GetEquipas()
        {
            var resultado = db.Equipas
                .Select(equipa => new
                {
                    equipa.ID,
                    equipa.Nome,
                    equipa.NomeTodo,
                    equipa.DataFundacao,
                    equipa.Pais,
                    equipa.Cidade,
                    equipa.Presidente,
                    equipa.Logotipo

                })
                .ToList();
            return Ok(resultado);
        }

        // GET: api/Equipas/5
        [ResponseType(typeof(Equipas))]
        [Route("api/equipas/{id}")]
        public IHttpActionResult GetEquipas(int id)
        {
            Equipas equipas = db.Equipas.Find(id);
            if (equipas == null)
            {
                return NotFound();
            }
            
            var dataFund = equipas.DataFundacao.ToString("dd/MM/yyyy");
            var resultado = db.Equipas.Select(equipa => new
            {
                equipa.ID,
                equipa.Nome,
                equipa.NomeTodo,
                dataFund,
                equipa.Pais,
                equipa.Cidade,
                equipa.Presidente,
                equipa.Logotipo,
                equipa.Plantel,
                equipa.EpocaCampeonatoPortugues,
                equipa.EpocaCampeonatoMetropolitano,
                equipa.EpocaTacaPortugal,
                equipa.EpocaSupertacaAntonioLivramento
            }).Where(equipa => equipa.ID == id).ToList();

            return Ok(resultado);
        }

        //GET : api/Equipas/Logotipo
        [ResponseType(typeof(Equipas))]
        [Route("api/equipas/logotipo")]
        public IHttpActionResult GetLogotipo()
        {
            var resultado = db.Equipas
               .Select(equipa => new
               {
                   equipa.Nome,
                   equipa.Logotipo
               })
               .ToList();
            return Ok(resultado);
        }


        //GET :api/Equipas/id/Historia
        [ResponseType(typeof(Equipas))]
        [Route("api/equipas/{id}/historia")]
        public IHttpActionResult GetHistoria(int id)
        {
            Equipas equipas = db.Equipas.Find(id);
            if (equipas == null)
            {
                return NotFound();
            }

            var resultado = new
            {
                equipas.Historia
            };


            return Ok(resultado);
        }
        
      

        //GET : api/Equipas/1/Jogadores
        [Route("api/equipas/{id}/jogadores")]
        public IHttpActionResult GetJogadoresEquipa(int id)
        {
            Equipas equipas = db.Equipas.Find(id);
            if (equipas == null)
            {
                return NotFound();
            }
            var jogadores = db.Jogadores.Where(j => j.EquipaPK == equipas.ID).Select(r => new 
            {
            r.ID,
            r.Nome,
            r.Número,
            r.Posicao,
            r.Fotografia

            }).ToList();

            return Ok(jogadores);
        }
        

        // PUT: api/Equipas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEquipas(int id, Equipas equipas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != equipas.ID)
            {
                return BadRequest();
            }

            db.Entry(equipas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipasExists(id))
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

        // POST: api/Equipas
        [ResponseType(typeof(Equipas))]
        public IHttpActionResult PostEquipas(Equipas equipas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Equipas.Add(equipas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = equipas.ID }, equipas);
        }

        // DELETE: api/Equipas/5
        [ResponseType(typeof(Equipas))]
        public IHttpActionResult DeleteEquipas(int id)
        {
            Equipas equipas = db.Equipas.Find(id);
            if (equipas == null)
            {
                return NotFound();
            }

            db.Equipas.Remove(equipas);
            db.SaveChanges();

            return Ok(equipas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EquipasExists(int id)
        {
            return db.Equipas.Count(e => e.ID == id) > 0;
        }
    }
}