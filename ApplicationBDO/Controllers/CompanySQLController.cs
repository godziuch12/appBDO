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

namespace ApplicationBDO.Controllers
{
    public class CompanySQLController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private int numberOfRecrds = 100000;

        // DATABASE MSSQL ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult Index()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "SQL").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var selectCompany = dbSQL.CompanyModels.ToList();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL";
            logs.OperationTime = timeLog;
            logs.OperationName = "SELECT";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = numberOfRecrds;
            logs.NumberOfFieldsModel = 10;
            logs.EntityFramework = true;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Insert()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var insertCompany = DeSerializeObject<List<CompanyModels>>("SerializationOverview");
            dbSQL.CompanyModels.AddRange(insertCompany);

            dbSQL.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL";
            logs.OperationTime = timeLog;
            logs.OperationName = "INSERT";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = numberOfRecrds;
            logs.NumberOfFieldsModel = 10;
            logs.EntityFramework = true;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var updateCompany = dbSQL.CompanyModels.ToList();
            foreach (var company in updateCompany)
            {
                company.Country = "Niemcy";
                dbSQL.Entry(company).State = EntityState.Modified;
            }

            dbSQL.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL";
            logs.OperationTime = timeLog;
            logs.OperationName = "UPDATE";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = numberOfRecrds;
            logs.NumberOfFieldsModel = 10;
            logs.EntityFramework = true;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var deleteCompany = dbSQL.CompanyModels.ToList();

            dbSQL.CompanyModels.RemoveRange(deleteCompany);

            dbSQL.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL";
            logs.OperationTime = timeLog;
            logs.OperationName = "DELETE";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = numberOfRecrds;
            logs.NumberOfFieldsModel = 10;
            logs.EntityFramework = true;

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
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(@"C://Users//adria//OneDrive//Pulpit//SerializationOverview.xml");
                string xmlString = xmlDocument.OuterXml;
                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);
                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }

            return objectOut;
        }
    }
}