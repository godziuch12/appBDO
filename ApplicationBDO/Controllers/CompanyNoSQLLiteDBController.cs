using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using LiteDB;
using MongoDB.Driver;

namespace ApplicationBDO.Controllers
{
    [Authorize]
    public class CompanyNoSQLLiteDBController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private string _connestionString = @"C:\Temp\MyDataLiteSQL.db";

        // DATABASE LITEDB ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult Index()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "NoSQL-LiteDB").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            using (var dbNoSQL = new LiteDatabase(_connestionString))
            {
                var companyCollection = dbNoSQL.GetCollection<CompanyModels>("company");

                var selectCompany = companyCollection.Find(f => true);
            }

            dbSQL.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL-LiteDB";
            logs.OperationTime = timeLog;
            logs.OperationName = "SELECT";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfRecords;
            logs.NumberOfFieldsModel = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfFieldsModel;
            logs.SizeFile = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").SizeFile;
            logs.EntityFramework = false;
            logs.BulkLoading = false;
            logs.NoTracing = false;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Insert()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var collectionCompanyFromFile = DeSerializeObject<List<CompanyModels>>("SerializationOverview");

            using (var dbNoSQL = new LiteDatabase(_connestionString))
            {
                var companyCollection = dbNoSQL.GetCollection<CompanyModels>("company");

                foreach (var item in collectionCompanyFromFile)
                {
                    companyCollection.Insert(new CompanyModels
                    {
                        Id = item.Id,
                        CompanyId = item.CompanyId,
                        Address = item.Address,
                        NIP = item.NIP,
                        Country = item.Country,
                        PostalCode = item.PostalCode,
                        RegistrationNumber = item.RegistrationNumber,
                        Pesel = item.Pesel,
                        Teryt = item.Teryt,
                        Name = item.Name
                    });
                }
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL-LiteDB";
            logs.OperationTime = timeLog;
            logs.OperationName = "INSERT";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfRecords;
            logs.NumberOfFieldsModel = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfFieldsModel;
            logs.SizeFile = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").SizeFile;
            logs.EntityFramework = false;
            logs.BulkLoading = false;
            logs.NoTracing = false;


            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            var update = Builders<CompanyModels>.Update.Set(s => s.Country, "Niemcy");
            int numberOfDocumentsPerSession = 10000;
            List<CompanyModels> objectListInChunks = new List<CompanyModels>();

            var timerSQL = new Stopwatch();
            timerSQL.Start();

            using (var dbNoSQL = new LiteDatabase(_connestionString))
            {
                var companyCollection = dbNoSQL.GetCollection<CompanyModels>("company");

                var selectCompany = companyCollection.Find(f => true);
                var selectCompanyCount = companyCollection.Find(f => true).Count();
                for (int i = 0; i < selectCompanyCount; i += numberOfDocumentsPerSession)
                {
                    var selectSkip = selectCompany.Skip(i).Take(numberOfDocumentsPerSession);
                    objectListInChunks.AddRange(selectSkip);

                    foreach (var item in objectListInChunks)
                    {
                        item.Country = "Niemcy";
                        companyCollection.Update(item);
                    }
                    objectListInChunks.Clear();
                }
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL-LiteDB";
            logs.OperationTime = timeLog;
            logs.OperationName = "UPDATE";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfRecords;
            logs.NumberOfFieldsModel = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfFieldsModel;
            logs.SizeFile = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").SizeFile;
            logs.EntityFramework = false;
            logs.BulkLoading = false;
            logs.NoTracing = false;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            using (var dbNoSQL = new LiteDatabase(_connestionString))
            {
                var companyCollection = dbNoSQL.GetCollection<CompanyModels>("company");

                companyCollection.DeleteMany(_ => true);
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL-LiteDB";
            logs.OperationTime = timeLog;
            logs.OperationName = "DELETE";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfRecords;
            logs.NumberOfFieldsModel = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfFieldsModel;
            logs.SizeFile = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").SizeFile;
            logs.EntityFramework = true;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }
  
            try
            {
                using (FileStream FStream = new FileStream("C://Users//adria//OneDrive//Pulpit//SerializationOverview.xml", FileMode.Open))
                {
                    var Deserializer = new XmlSerializer(typeof(T));
                    return (T)Deserializer.Deserialize(FStream);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
