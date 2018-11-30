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
    public class TipoAudienciaController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: TipoAudiencia
        public ActionResult Index()
        {
            return View(db.TTipoAudiencia.ToList());
        }

        // GET: TipoAudiencia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTipoAudiencia tTipoAudiencia = db.TTipoAudiencia.Find(id);
            if (tTipoAudiencia == null)
            {
                return HttpNotFound();
            }
            return View(tTipoAudiencia);
        }

        // GET: TipoAudiencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoAudiencia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTipoAudiencia,Descripcion")] TTipoAudiencia tTipoAudiencia)
        {
            if (ModelState.IsValid)
            {
                db.TTipoAudiencia.Add(tTipoAudiencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tTipoAudiencia);
        }

        // GET: TipoAudiencia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTipoAudiencia tTipoAudiencia = db.TTipoAudiencia.Find(id);
            if (tTipoAudiencia == null)
            {
                return HttpNotFound();
            }
            return View(tTipoAudiencia);
        }

        // POST: TipoAudiencia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTipoAudiencia,Descripcion")] TTipoAudiencia tTipoAudiencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tTipoAudiencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tTipoAudiencia);
        }

        // GET: TipoAudiencia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTipoAudiencia tTipoAudiencia = db.TTipoAudiencia.Find(id);
            if (tTipoAudiencia == null)
            {
                return HttpNotFound();
            }
            return View(tTipoAudiencia);
        }

        // POST: TipoAudiencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TTipoAudiencia tTipoAudiencia = db.TTipoAudiencia.Find(id);
            db.TTipoAudiencia.Remove(tTipoAudiencia);
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
