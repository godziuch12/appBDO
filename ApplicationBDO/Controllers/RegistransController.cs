using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApplicationBDO.Models;

namespace ApplicationBDO.Controllers
{
    public class RegistransController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Registrans
        public ActionResult Index()
        {
            return View(db.RegistransModels.ToList());
        }

        // GET: Registrans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistransModels registransModels = db.RegistransModels.Find(id);
            if (registransModels == null)
            {
                return HttpNotFound();
            }
            return View(registransModels);
        }

        // GET: Registrans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registrans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NIP,NumerRejestrowy,Adres,Nazwa")] RegistransModels registransModels)
        {
            if (ModelState.IsValid)
            {
                db.RegistransModels.Add(registransModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registransModels);
        }

        // GET: Registrans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistransModels registransModels = db.RegistransModels.Find(id);
            if (registransModels == null)
            {
                return HttpNotFound();
            }
            return View(registransModels);
        }

        // POST: Registrans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NIP,NumerRejestrowy,Adres,Nazwa")] RegistransModels registransModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registransModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registransModels);
        }

        // GET: Registrans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistransModels registransModels = db.RegistransModels.Find(id);
            if (registransModels == null)
            {
                return HttpNotFound();
            }
            return View(registransModels);
        }

        // POST: Registrans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistransModels registransModels = db.RegistransModels.Find(id);
            db.RegistransModels.Remove(registransModels);
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
