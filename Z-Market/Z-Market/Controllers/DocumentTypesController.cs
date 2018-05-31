using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Z_Market.Models;

namespace Z_Market.Controllers
{
    public class DocumentTypesController : Controller
    {
        private Z_MarketContext db = new Z_MarketContext();

        // GET: /DocumentTypes/
        public ActionResult Index()
        {
            return View(db.DocumentTypes.ToList());
        }

        // GET: /DocumentTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentType documenttype = db.DocumentTypes.Find(id);
            if (documenttype == null)
            {
                return HttpNotFound();
            }
            return View(documenttype);
        }

        // GET: /DocumentTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /DocumentTypes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="DocumentTypeID,Description")] DocumentType documenttype)
        {
            if (ModelState.IsValid)
            {
                db.DocumentTypes.Add(documenttype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(documenttype);
        }

        // GET: /DocumentTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentType documenttype = db.DocumentTypes.Find(id);
            if (documenttype == null)
            {
                return HttpNotFound();
            }
            return View(documenttype);
        }

        // POST: /DocumentTypes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="DocumentTypeID,Description")] DocumentType documenttype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(documenttype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(documenttype);
        }

        // GET: /DocumentTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentType documenttype = db.DocumentTypes.Find(id);
            if (documenttype == null)
            {
                return HttpNotFound();
            }
            return View(documenttype);
        }

        // POST: /DocumentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DocumentType documenttype = db.DocumentTypes.Find(id);
            db.DocumentTypes.Remove(documenttype);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                
            }
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
