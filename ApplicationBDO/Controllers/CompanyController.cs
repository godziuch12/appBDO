using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ApplicationBDO.Models;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using MongoDB.Driver;

namespace ApplicationBDO.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private MongoDBContext dbNoSQL = new MongoDBContext();
        private IMongoCollection<CompanyMongoModels> companyCollection;

        public CompanyController()
        {
            companyCollection = dbNoSQL.database.GetCollection<CompanyMongoModels>("Company");
        }
        public ActionResult IndexSQL()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();
            var companySQL = dbSQL.CompanyModels.ToList();
            timerSQL.Stop();
            TimeSpan timeTakenSQL = timerSQL.Elapsed;
            var timeLogSQL = timeTakenSQL.ToString(@"m\:ss\.fff");

            var logsSQL = new LogModels();
            logsSQL.DataOperacji = DateTime.Now;
            logsSQL.BazaDanych = "SQL";
            logsSQL.CzasOperacji = timeLogSQL;
            logsSQL.NazwaOperacji = "LIST";
            dbSQL.LogModels.Add(logsSQL);

            dbSQL.SaveChanges();

            return View(dbSQL.CompanyModels.ToList());
        }

        public ActionResult IndexNoSQL()
        {
            var timerMongo = new Stopwatch();

            timerMongo.Start();
            var companyMongo = companyCollection.AsQueryable<CompanyMongoModels>().ToList();
            timerMongo.Stop();

            TimeSpan timeTakenMongo = timerMongo.Elapsed;
            var timeLogMongo = timeTakenMongo.ToString(@"m\:ss\.fff");

            var logsMongo = new LogModels();
            logsMongo.DataOperacji = DateTime.Now;
            logsMongo.BazaDanych = "NoSQL";
            logsMongo.CzasOperacji = timeLogMongo;
            logsMongo.NazwaOperacji = "LIST";
            dbSQL.LogModels.Add(logsMongo);

            return View(companyMongo.ToList());
        }

        public ActionResult GetCompanySQL()
        {
            var conf = Configuration();

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

                dbSQL.CompanyModels.Add(company);
            }

            dbSQL.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTakenSQL = timerSQL.Elapsed;
            var timeLogSQL = timeTakenSQL.ToString(@"m\:ss\.fff");

            var logsSQL = new LogModels();
            logsSQL.DataOperacji = DateTime.Now;
            logsSQL.BazaDanych = "SQL";
            logsSQL.CzasOperacji = timeLogSQL;
            logsSQL.NazwaOperacji = "GET";

            dbSQL.LogModels.Add(logsSQL);
            dbSQL.SaveChanges();

            return RedirectToAction("IndexSQL");
        }

        public ActionResult GetCompanyNoSQL()
        {
            var conf = Configuration();

            SearchApi search = new SearchApi(conf);
            var companyList = search.SearchCompany("10");

            var timerSQL = new Stopwatch();
            timerSQL.Start();

            foreach (var item in companyList)
            {
                companyCollection.InsertOne(new CompanyMongoModels
                {
                    Id = Guid.NewGuid(),
                    CompanyId = item.CompanyId,
                    Address = item.Address,
                    NIP = item.Nip,
                    Country = item.Country,
                    PostalCode = item.PostalCode,
                    RegistrationNumber = item.RegistrationNumber,
                    Pesel = item.Pesel,
                    Teryt = item.Teryt
                });
            }

            timerSQL.Stop();

            TimeSpan timeTakenSQL = timerSQL.Elapsed;
            var timeLogSQL = timeTakenSQL.ToString(@"m\:ss\.fff");

            var logsSQL = new LogModels();
            logsSQL.DataOperacji = DateTime.Now;
            logsSQL.BazaDanych = "NoSQL";
            logsSQL.CzasOperacji = timeLogSQL;
            logsSQL.NazwaOperacji = "GET";

            dbSQL.LogModels.Add(logsSQL);
            dbSQL.SaveChanges();

            return RedirectToAction("IndexNoSQL");
        }

        public Configuration Configuration()
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

            return conf;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt")] CompanyModels companyModels)
        {
            if (ModelState.IsValid)
            {
                dbSQL.CompanyModels.Add(companyModels);
                dbSQL.SaveChanges();
                return RedirectToAction("IndexSQL");
            }

            return View(companyModels);
        }

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyModels companyModels = dbSQL.CompanyModels.Find(id);
            if (companyModels == null)
            {
                return HttpNotFound();
            }
            return View(companyModels);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt")] CompanyModels companyModels)
        {
            if (ModelState.IsValid)
            {
                dbSQL.Entry(companyModels).State = EntityState.Modified;
                dbSQL.SaveChanges();
                return RedirectToAction("IndexSQL");
            }
            return View(companyModels);
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyModels companyModels = dbSQL.CompanyModels.Find(id);
            if (companyModels == null)
            {
                return HttpNotFound();
            }
            return View(companyModels);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CompanyModels companyModels = dbSQL.CompanyModels.Find(id);
            dbSQL.CompanyModels.Remove(companyModels);
            dbSQL.SaveChanges();

            return RedirectToAction("IndexSQL");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbSQL.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
