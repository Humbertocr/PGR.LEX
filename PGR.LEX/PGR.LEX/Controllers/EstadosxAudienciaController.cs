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
    public class EstadosxAudienciaController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: EstadosxAudiencia
        public ActionResult Index()
        {
            return View(db.TEstadosxAudiencia.ToList());
        }

        // GET: EstadosxAudiencia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TEstadosxAudiencia tEstadosxAudiencia = db.TEstadosxAudiencia.Find(id);
            if (tEstadosxAudiencia == null)
            {
                return HttpNotFound();
            }
            return View(tEstadosxAudiencia);
        }

        // GET: EstadosxAudiencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadosxAudiencia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEstado,Descripcion")] TEstadosxAudiencia tEstadosxAudiencia)
        {
            if (ModelState.IsValid)
            {
                db.TEstadosxAudiencia.Add(tEstadosxAudiencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tEstadosxAudiencia);
        }

        // GET: EstadosxAudiencia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TEstadosxAudiencia tEstadosxAudiencia = db.TEstadosxAudiencia.Find(id);
            if (tEstadosxAudiencia == null)
            {
                return HttpNotFound();
            }
            return View(tEstadosxAudiencia);
        }

        // POST: EstadosxAudiencia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEstado,Descripcion")] TEstadosxAudiencia tEstadosxAudiencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tEstadosxAudiencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tEstadosxAudiencia);
        }

        // GET: EstadosxAudiencia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TEstadosxAudiencia tEstadosxAudiencia = db.TEstadosxAudiencia.Find(id);
            if (tEstadosxAudiencia == null)
            {
                return HttpNotFound();
            }
            return View(tEstadosxAudiencia);
        }

        // POST: EstadosxAudiencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TEstadosxAudiencia tEstadosxAudiencia = db.TEstadosxAudiencia.Find(id);
            db.TEstadosxAudiencia.Remove(tEstadosxAudiencia);
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
