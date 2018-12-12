using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PGR.LEX.Models;

namespace PGR.LEX.Content
{
    public class TerrenosAfectadosController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: TerrenosAfectados
        public ActionResult Index()
        {
            return View(db.TTerrenosAfectados.ToList());
        }

        // GET: TerrenosAfectados/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTerrenosAfectados tTerrenosAfectados = db.TTerrenosAfectados.Find(id);
            if (tTerrenosAfectados == null)
            {
                return HttpNotFound();
            }
            return View(tTerrenosAfectados);
        }

        // GET: TerrenosAfectados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TerrenosAfectados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Terreno_Afectado,Nombre")] TTerrenosAfectados tTerrenosAfectados)
        {
            if (ModelState.IsValid)
            {
                db.TTerrenosAfectados.Add(tTerrenosAfectados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tTerrenosAfectados);
        }

        // GET: TerrenosAfectados/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTerrenosAfectados tTerrenosAfectados = db.TTerrenosAfectados.Find(id);
            if (tTerrenosAfectados == null)
            {
                return HttpNotFound();
            }
            return View(tTerrenosAfectados);
        }

        // POST: TerrenosAfectados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Terreno_Afectado,Nombre")] TTerrenosAfectados tTerrenosAfectados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tTerrenosAfectados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tTerrenosAfectados);
        }

        // GET: TerrenosAfectados/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTerrenosAfectados tTerrenosAfectados = db.TTerrenosAfectados.Find(id);
            if (tTerrenosAfectados == null)
            {
                return HttpNotFound();
            }
            return View(tTerrenosAfectados);
        }

        // POST: TerrenosAfectados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            TTerrenosAfectados tTerrenosAfectados = db.TTerrenosAfectados.Find(id);
            db.TTerrenosAfectados.Remove(tTerrenosAfectados);
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
