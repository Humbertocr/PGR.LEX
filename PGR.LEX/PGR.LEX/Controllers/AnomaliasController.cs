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
    public class AnomaliasController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: Anomalias
        public ActionResult Index()
        {
            return View(db.TAnomalias.ToList());
        }

        // GET: Anomalias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAnomalias tAnomalias = db.TAnomalias.Find(id);
            if (tAnomalias == null)
            {
                return HttpNotFound();
            }
            return View(tAnomalias);
        }

        // GET: Anomalias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anomalias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAnomalia,Descripcion")] TAnomalias tAnomalias)
        {
            if (ModelState.IsValid)
            {
                db.TAnomalias.Add(tAnomalias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tAnomalias);
        }

        // GET: Anomalias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAnomalias tAnomalias = db.TAnomalias.Find(id);
            if (tAnomalias == null)
            {
                return HttpNotFound();
            }
            return View(tAnomalias);
        }

        // POST: Anomalias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAnomalia,Descripcion")] TAnomalias tAnomalias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tAnomalias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tAnomalias);
        }

        // GET: Anomalias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAnomalias tAnomalias = db.TAnomalias.Find(id);
            if (tAnomalias == null)
            {
                return HttpNotFound();
            }
            return View(tAnomalias);
        }

        // POST: Anomalias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TAnomalias tAnomalias = db.TAnomalias.Find(id);
            db.TAnomalias.Remove(tAnomalias);
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
