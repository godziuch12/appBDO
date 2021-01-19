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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ApplicationBDO.Controllers
{
    public class WasteCodeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: WasteCode
        public ActionResult Index()
        {
            return View(db.WasteCodeModels.ToList());
        }

        public ActionResult GetWasteCode()
        {
            Configuration conf = new Configuration();
            AuthApi authApi = new AuthApi(conf);
            var requestEup = new WasteRegisterPublicApiApiModelsRequestsAuthV1EupRequest();
            requestEup.ClientId = "a9b06fba-e707-47ef-b21a-c9f25932e17c";
            requestEup.ClientSecret = "f67194ff2f5643b08634a0c006ca7cab7095db4394b149daaa93254199790969";
            requestEup.PaginationParameters = new WasteRegisterPublicApiApiModelsRequestsAuthV1AuthPaginationParameters()
            {
                Order = new WasteRegisterPublicApiApiModelsRequestsAuthV1Aorder() { IsAscending = true },
                Page = new WasteRegisterPublicApiApiModelsRequestsAuthV1Apage() { Index = 1, Size = 10 },
            };

            var responseEup = authApi.GetEupList(requestEup);

            var requestToken = new WasteRegisterPublicApiApiModelsRequestsAuthV1JwtRequest();
            requestToken.EupId = responseEup.Items[0].EupId.ToString();
            requestToken.ClientId = "a9b06fba-e707-47ef-b21a-c9f25932e17c";
            requestToken.ClientSecret = "f67194ff2f5643b08634a0c006ca7cab7095db4394b149daaa93254199790969";

            var responseToken = authApi.GenerateEupAccessToken(requestToken);

            conf.AccessToken = responseToken.AccessToken;
            conf.Password = "npah7550BS";
            conf.Username = "User_333124";
            conf.AddApiKey("Authorization", conf.AccessToken);
            conf.AddApiKeyPrefix("Authorization", "Bearer");

            SearchApi search = new SearchApi(conf);
            var companyList = search.SearchCompany("10");

            var timerSQL = new Stopwatch();
            timerSQL.Start();
            foreach (var item in companyList)
            {
                var company = new CompanyModels();
                company.CompanyId = item.CompanyId;
                company.Address = item.Address;
                company.NIP = item.Nip;
                company.Country = item.Country;
                company.PostalCode = item.PostalCode;
                company.RegistrationNumber = item.RegistrationNumber;
                company.Pesel = item.Pesel;
                company.Teryt = item.Teryt;

                db.CompanyModels.Add(company);
            }

            db.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTakenSQL = timerSQL.Elapsed;
            var timeLogSQL = timeTakenSQL.ToString(@"m\:ss\.fff");

            var logsSQL = new LogModels();
            logsSQL.DataOperacji = DateTime.Now;
            logsSQL.BazaDanych = "SQL";
            logsSQL.CzasOperacji = timeLogSQL;
            logsSQL.NazwaOperacji = "Dodanie kodow odpadow z api";
            db.LogModels.Add(logsSQL);


            return RedirectToAction("Index");
        }
        
        // GET: WasteCode/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WasteCodeModels wasteCodeModels = db.WasteCodeModels.Find(id);
            if (wasteCodeModels == null)
            {
                return HttpNotFound();
            }
            return View(wasteCodeModels);
        }

        // GET: WasteCode/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WasteCode/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,WasteCodeId,DateCreated,Code,Description,IsDangerous,Deleted,Level,ParentId")] WasteCodeModels wasteCodeModels)
        {
            if (ModelState.IsValid)
            {
                db.WasteCodeModels.Add(wasteCodeModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wasteCodeModels);
        }

        // GET: WasteCode/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WasteCodeModels wasteCodeModels = db.WasteCodeModels.Find(id);
            if (wasteCodeModels == null)
            {
                return HttpNotFound();
            }
            return View(wasteCodeModels);
        }

        // POST: WasteCode/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,WasteCodeId,DateCreated,Code,Description,IsDangerous,Deleted,Level,ParentId")] WasteCodeModels wasteCodeModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wasteCodeModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wasteCodeModels);
        }

        // GET: WasteCode/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WasteCodeModels wasteCodeModels = db.WasteCodeModels.Find(id);
            if (wasteCodeModels == null)
            {
                return HttpNotFound();
            }
            return View(wasteCodeModels);
        }

        // POST: WasteCode/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WasteCodeModels wasteCodeModels = db.WasteCodeModels.Find(id);
            db.WasteCodeModels.Remove(wasteCodeModels);
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
