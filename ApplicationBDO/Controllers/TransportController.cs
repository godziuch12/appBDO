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
    public class TransportController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Transport
        public ActionResult Index()
        {
            return View(db.TransportModels.ToList());
        }

        // GET: Transport/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransportModels transportModels = db.TransportModels.Find(id);
            if (transportModels == null)
            {
                return HttpNotFound();
            }
            return View(transportModels);
        }

        // GET: Transport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transport/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NIP,NumerRejestrowy,Adres,Nazwa")] TransportModels transportModels)
        {
            if (ModelState.IsValid)
            {
                db.TransportModels.Add(transportModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transportModels);
        }

        // GET: Transport/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransportModels transportModels = db.TransportModels.Find(id);
            if (transportModels == null)
            {
                return HttpNotFound();
            }
            return View(transportModels);
        }

        // POST: Transport/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NIP,NumerRejestrowy,Adres,Nazwa")] TransportModels transportModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transportModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transportModels);
        }

        // GET: Transport/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransportModels transportModels = db.TransportModels.Find(id);
            if (transportModels == null)
            {
                return HttpNotFound();
            }
            return View(transportModels);
        }

        // POST: Transport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TransportModels transportModels = db.TransportModels.Find(id);
            db.TransportModels.Remove(transportModels);
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
