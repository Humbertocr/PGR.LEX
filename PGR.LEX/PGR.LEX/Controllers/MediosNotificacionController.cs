using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PGR.LEX.Models;

namespace PGR.LEX.Controllers
{
    public class MediosNotificacionController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: MediosNotificacion
        public ActionResult Index()
        {
            return View(db.TMediosNotificacion.ToList());
        }

        // GET: MediosNotificacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TMediosNotificacion tMediosNotificacion = db.TMediosNotificacion.Find(id);
            if (tMediosNotificacion == null)
            {
                return HttpNotFound();
            }
            return View(tMediosNotificacion);
        }

        // GET: MediosNotificacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediosNotificacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idMedioNotificacion,Descripcion")] TMediosNotificacion tMediosNotificacion)
        {
            if (ModelState.IsValid)
            {
                db.TMediosNotificacion.Add(tMediosNotificacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tMediosNotificacion);
        }

        // GET: MediosNotificacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TMediosNotificacion tMediosNotificacion = db.TMediosNotificacion.Find(id);
            if (tMediosNotificacion == null)
            {
                return HttpNotFound();
            }
            return View(tMediosNotificacion);
        }

        // POST: MediosNotificacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idMedioNotificacion,Descripcion")] TMediosNotificacion tMediosNotificacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tMediosNotificacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tMediosNotificacion);
        }

        // GET: MediosNotificacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TMediosNotificacion tMediosNotificacion = db.TMediosNotificacion.Find(id);
            if (tMediosNotificacion == null)
            {
                return HttpNotFound();
            }
            return View(tMediosNotificacion);
        }

        // POST: MediosNotificacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TMediosNotificacion tMediosNotificacion = db.TMediosNotificacion.Find(id);
            db.TMediosNotificacion.Remove(tMediosNotificacion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
