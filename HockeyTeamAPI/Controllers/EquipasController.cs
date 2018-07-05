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
    public class EquipasController : ApiController
    {
        private HockeyDB db = new HockeyDB();

        // GET: api/Equipas
        public IQueryable<Equipas> GetEquipas()
        {
            return db.Equipas;
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

            return Ok(equipas);
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