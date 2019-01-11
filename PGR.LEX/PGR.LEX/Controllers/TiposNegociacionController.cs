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
    public class TiposNegociacionController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: TiposNegociacion
        public ActionResult Index()
        {
            return View(db.TTiposNegociacion.ToList());
        }

        // GET: TiposNegociacion/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTiposNegociacion tTiposNegociacion = db.TTiposNegociacion.Find(id);
            if (tTiposNegociacion == null)
            {
                return HttpNotFound();
            }
            return View(tTiposNegociacion);
        }

        // GET: TiposNegociacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposNegociacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Tipo_Negociacion,Nombre")] TTiposNegociacion tTiposNegociacion)
        {
            if (ModelState.IsValid)
            {
                db.TTiposNegociacion.Add(tTiposNegociacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tTiposNegociacion);
        }

        // GET: TiposNegociacion/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTiposNegociacion tTiposNegociacion = db.TTiposNegociacion.Find(id);
            if (tTiposNegociacion == null)
            {
                return HttpNotFound();
            }
            return View(tTiposNegociacion);
        }

        // POST: TiposNegociacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Tipo_Negociacion,Nombre")] TTiposNegociacion tTiposNegociacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tTiposNegociacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tTiposNegociacion);
        }

        // GET: TiposNegociacion/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTiposNegociacion tTiposNegociacion = db.TTiposNegociacion.Find(id);
            if (tTiposNegociacion == null)
            {
                return HttpNotFound();
            }
            return View(tTiposNegociacion);
        }

        // POST: TiposNegociacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            TTiposNegociacion tTiposNegociacion = db.TTiposNegociacion.Find(id);
            db.TTiposNegociacion.Remove(tTiposNegociacion);
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
