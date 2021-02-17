using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using Microsoft.Ajax.Utilities;

namespace ApplicationBDO.Controllers
{
    public class CompanySQLMSSQLExpressController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();

        // DATABASE MSSQL ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult Index()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "SQL-MSSQLExpress").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var selectCompany = dbSQL.CompanyModels;

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MSSQLExpress";
            logs.OperationTime = timeLog;
            logs.OperationName = "SELECT";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfRecords;
            logs.NumberOfFieldsModel = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfFieldsModel;
            logs.SizeFile = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").SizeFile;
            logs.EntityFramework = true;
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

            int numberOfDocumentsPerSession = 100000;
            List<CompanyModels> objectListInChunks = new List<CompanyModels>();
            var collectionCompanyFromFile = DeSerializeObject<List<CompanyModels>>("SerializationOverview");

            for (int i = 0; i < collectionCompanyFromFile.Count; i += numberOfDocumentsPerSession)
            {
                objectListInChunks.AddRange(collectionCompanyFromFile.Skip(i).Take(numberOfDocumentsPerSession));
                dbSQL.CompanyModels.AddRange(objectListInChunks);
                dbSQL.SaveChanges();
                dbSQL.Dispose();
                dbSQL = new ApplicationDbContext();
                objectListInChunks.Clear();
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MSSQLExpress";
            logs.OperationTime = timeLog;
            logs.OperationName = "INSERT";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfRecords;
            logs.NumberOfFieldsModel = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfFieldsModel;
            logs.SizeFile = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").SizeFile;
            logs.EntityFramework = true;
            logs.BulkLoading = false;
            logs.NoTracing = false;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            int numberOfDocumentsPerSession = 100000;
            List<CompanyModels> objectListInChunks = new List<CompanyModels>();
            var selectCompany = dbSQL.CompanyModels.OrderBy(m=>m.Country);
            var countCompany = dbSQL.CompanyModels.Count();
            for (int i = 0; i < countCompany; i += numberOfDocumentsPerSession)
            {
                objectListInChunks.AddRange(selectCompany.Skip(i).Take(numberOfDocumentsPerSession));
                objectListInChunks.ForEach(m => m.Country = "Niemcy");
                dbSQL.SaveChanges();
                objectListInChunks.Clear();
            }

            dbSQL.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MSSQLExpress";
            logs.OperationTime = timeLog;
            logs.OperationName = "UPDATE";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfRecords;
            logs.NumberOfFieldsModel = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfFieldsModel;
            logs.SizeFile = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").SizeFile;
            logs.EntityFramework = true;
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

            int numberOfDocumentsPerSession = 100000;
            List<CompanyModels> objectListInChunks = new List<CompanyModels>();
            var selectCompany = dbSQL.CompanyModels.OrderBy(m => m.Country);
            var countCompany = dbSQL.CompanyModels.Count();
            for (int i = 0; i < countCompany; i += numberOfDocumentsPerSession)
            {
                objectListInChunks.AddRange(selectCompany.Skip(i).Take(numberOfDocumentsPerSession));
                dbSQL.CompanyModels.RemoveRange(objectListInChunks);
                dbSQL.SaveChanges();
                objectListInChunks.Clear();
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MSSQLExpress";
            logs.OperationTime = timeLog;
            logs.OperationName = "DELETE";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfRecords;
            logs.NumberOfFieldsModel = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").NumberOfFieldsModel;
            logs.SizeFile = dbSQL.LogModels.FirstOrDefault(m => m.OperationName == "LOAD").SizeFile;
            logs.EntityFramework = true;
            logs.BulkLoading = false;
            logs.NoTracing = false;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }
            T objectOut = default(T);
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

            return objectOut;
        }
    }
}