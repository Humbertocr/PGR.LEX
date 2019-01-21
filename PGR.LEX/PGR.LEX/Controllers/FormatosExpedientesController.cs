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
    public class FormatosExpedientesController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: FormatosExpedientes
        public ActionResult Index()
        {
            return View(db.TFormatosExpedientes.ToList());
        }

        // GET: FormatosExpedientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TFormatosExpedientes tFormatosExpedientes = db.TFormatosExpedientes.Find(id);
            if (tFormatosExpedientes == null)
            {
                return HttpNotFound();
            }
            return View(tFormatosExpedientes);
        }

        // GET: FormatosExpedientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormatosExpedientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdFormato,Descripcion,ExpresionRegular")] TFormatosExpedientes tFormatosExpedientes)
        {
            if (ModelState.IsValid)
            {
                db.TFormatosExpedientes.Add(tFormatosExpedientes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tFormatosExpedientes);
        }

        // GET: FormatosExpedientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TFormatosExpedientes tFormatosExpedientes = db.TFormatosExpedientes.Find(id);
            if (tFormatosExpedientes == null)
            {
                return HttpNotFound();
            }
            return View(tFormatosExpedientes);
        }

        // POST: FormatosExpedientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFormato,Descripcion,ExpresionRegular")] TFormatosExpedientes tFormatosExpedientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tFormatosExpedientes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tFormatosExpedientes);
        }

        // GET: FormatosExpedientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TFormatosExpedientes tFormatosExpedientes = db.TFormatosExpedientes.Find(id);
            if (tFormatosExpedientes == null)
            {
                return HttpNotFound();
            }
            return View(tFormatosExpedientes);
        }

        // POST: FormatosExpedientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TFormatosExpedientes tFormatosExpedientes = db.TFormatosExpedientes.Find(id);
            db.TFormatosExpedientes.Remove(tFormatosExpedientes);
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
