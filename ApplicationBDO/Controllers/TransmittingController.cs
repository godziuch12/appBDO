using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApplicationBDO.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ApplicationBDO.Controllers
{
    public class TransmittingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private MongoDBContext dbcontext;
        private IMongoCollection<TransmittingMongoModels> transmittingCollection;
        // GET: Transmitting

        public TransmittingController()
        {
            dbcontext = new MongoDBContext();
            transmittingCollection = dbcontext.database.GetCollection<TransmittingMongoModels>("Transmitting");
        }

        public ActionResult Index()
        {
            var timerMongo = new Stopwatch();
            timerMongo.Start();
            var transmittingMongo = transmittingCollection.AsQueryable<TransmittingMongoModels>().ToList();
            timerMongo.Stop();
            TimeSpan timeTakenMongo = timerMongo.Elapsed;
            var timeLogMongo = timeTakenMongo.ToString(@"m\:ss\.fff");

            var timerSQL = new Stopwatch();
            timerSQL.Start();
            var transmittingSQL = db.TransmittingModels.ToList();
            timerSQL.Stop();
            TimeSpan timeTakenSQL = timerSQL.Elapsed;
            var timeLogSQL = timeTakenSQL.ToString(@"m\:ss\.fff");

            var logsMongo = new LogModels();
            logsMongo.DataOperacji = DateTime.Now;
            logsMongo.BazaDanych = "Mongo";
            logsMongo.CzasOperacji = timeLogMongo;
            logsMongo.NazwaOperacji = "List";
            db.LogModels.Add(logsMongo);

            var logsSQL = new LogModels();
            logsSQL.DataOperacji = DateTime.Now;
            logsSQL.BazaDanych = "SQL";
            logsSQL.CzasOperacji = timeLogSQL;
            logsSQL.NazwaOperacji = "List";
            db.LogModels.Add(logsSQL);

            db.SaveChanges();


            return View(db.TransmittingModels.ToList().Take(5));
        }

        // GET: Transmitting/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransmittingModels transmittingModels = db.TransmittingModels.Find(id);
            if (transmittingModels == null)
            {
                return HttpNotFound();
            }
            return View(transmittingModels);
        }

        // GET: Transmitting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transmitting/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NIP,NumerRejestrowy,Adres,Nazwa")] TransmittingModels transmittingModels)
        {
            if (ModelState.IsValid)
            {
                db.TransmittingModels.Add(transmittingModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transmittingModels);
        }

        // GET: Transmitting/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransmittingModels transmittingModels = db.TransmittingModels.Find(id);
            if (transmittingModels == null)
            {
                return HttpNotFound();
            }
            return View(transmittingModels);
        }

        // POST: Transmitting/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NIP,NumerRejestrowy,Adres,Nazwa")] TransmittingModels transmittingModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transmittingModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transmittingModels);
        }

        // GET: Transmitting/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransmittingModels transmittingModels = db.TransmittingModels.Find(id);
            if (transmittingModels == null)
            {
                return HttpNotFound();
            }
            return View(transmittingModels);
        }

        // POST: Transmitting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var timerMongo = new Stopwatch();
            timerMongo.Start();
            var transmittingMongo = transmittingCollection.DeleteOne(Builders<TransmittingMongoModels>.Filter.Eq("_id", ObjectId.Parse("5e49a49c7622957a3494e25d")));
            timerMongo.Stop();
            TimeSpan timeTakenMongo = timerMongo.Elapsed;
            var timeLogMongo = timeTakenMongo.ToString(@"m\:ss\.fff");

            var timerSQL = new Stopwatch();
            timerSQL.Start();
            TransmittingModels transmittingModels = db.TransmittingModels.Find(id);
            db.TransmittingModels.Remove(transmittingModels);
            timerSQL.Stop();
            TimeSpan timeTakenSQL = timerSQL.Elapsed;
            var timeLogSQL = timeTakenSQL.ToString(@"m\:ss\.fff");

            var logsMongo = new LogModels();
            logsMongo.DataOperacji = DateTime.Now;
            logsMongo.BazaDanych = "Mongo";
            logsMongo.CzasOperacji = timeLogMongo;
            logsMongo.NazwaOperacji = "Delete";
            db.LogModels.Add(logsMongo);

            var logsSQL = new LogModels();
            logsSQL.DataOperacji = DateTime.Now;
            logsSQL.BazaDanych = "SQL";
            logsSQL.CzasOperacji = timeLogSQL;
            logsSQL.NazwaOperacji = "Delete";
            db.LogModels.Add(logsSQL);

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
