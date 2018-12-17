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
    public class MonedaController : Controller
    {
        private LitigiosoEntities db = new LitigiosoEntities();

        // GET: Moneda
        public ActionResult Index()
        {
            return View(db.TMoneda.ToList());
        }

        // GET: Moneda/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TMoneda tMoneda = db.TMoneda.Find(id);
            if (tMoneda == null)
            {
                return HttpNotFound();
            }
            return View(tMoneda);
        }

        // GET: Moneda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Moneda/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
 
        [ValidateAntiForgeryToken]
       
        public ActionResult Create([Bind(Include = "idMoneda,Descripcion")] TMoneda tMoneda)
        {
            if (ModelState.IsValid)
            {
                db.TMoneda.Add(tMoneda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tMoneda);
        }

        // GET: Moneda/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TMoneda tMoneda = db.TMoneda.Find(id);
            if (tMoneda == null)
            {
                return HttpNotFound();
            }
            return View(tMoneda);
        }

        // POST: Moneda/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idMoneda,Descripcion")] TMoneda tMoneda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tMoneda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tMoneda);
        }

        // GET: Moneda/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TMoneda tMoneda = db.TMoneda.Find(id);
            if (tMoneda == null)
            {
                return HttpNotFound();
            }
            return View(tMoneda);
        }

        // POST: Moneda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TMoneda tMoneda = db.TMoneda.Find(id);
            db.TMoneda.Remove(tMoneda);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //[ValidateAntiForgeryToken]
        public ActionResult Borrar(int id)
        {
            TMoneda tMoneda = db.TMoneda.Find(id);
            db.TMoneda.Remove(tMoneda);
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
