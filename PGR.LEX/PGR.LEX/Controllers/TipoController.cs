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
    public class TipoController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: Tipo
        public ActionResult Index()
        {
            var tTipo = db.TTipo.Include(t => t.TMateria);
            return View(tTipo.ToList());
        }

        // GET: Tipo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTipo tTipo = db.TTipo.Find(id);
            if (tTipo == null)
            {
                return HttpNotFound();
            }
            return View(tTipo);
        }

        // GET: Tipo/Create
        public ActionResult Create()
        {
            ViewBag.MatIdMateria = new SelectList(db.TMateria, "idMateria", "Descripcion");
            return View();
        }

        // POST: Tipo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTipo,MatIdMateria,Descripcion")] TTipo tTipo)
        {
            if (ModelState.IsValid)
            {
                db.TTipo.Add(tTipo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MatIdMateria = new SelectList(db.TMateria, "idMateria", "Descripcion", tTipo.MatIdMateria);
            return View(tTipo);
        }

        // GET: Tipo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTipo tTipo = db.TTipo.Find(id);
            if (tTipo == null)
            {
                return HttpNotFound();
            }
            ViewBag.MatIdMateria = new SelectList(db.TMateria, "idMateria", "Descripcion", tTipo.MatIdMateria);
            return View(tTipo);
        }

        // POST: Tipo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTipo,MatIdMateria,Descripcion")] TTipo tTipo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tTipo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MatIdMateria = new SelectList(db.TMateria, "idMateria", "Descripcion", tTipo.MatIdMateria);
            return View(tTipo);
        }

        // GET: Tipo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTipo tTipo = db.TTipo.Find(id);
            if (tTipo == null)
            {
                return HttpNotFound();
            }
            return View(tTipo);
        }

        // POST: Tipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TTipo tTipo = db.TTipo.Find(id);
            db.TTipo.Remove(tTipo);
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
