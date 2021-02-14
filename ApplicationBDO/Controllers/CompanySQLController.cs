using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using MongoDB.Driver;

namespace ApplicationBDO.Controllers
{
    public class CompanySQLController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private int numberOfRecrds = 100000;

        // DATABASE MSSQL ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult IndexFileToSql()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "SQL").ToList());
        }

        public ActionResult SelectFileToSql()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var selectCompanyFromFile = dbSQL.CompanyModels.ToList();

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

            return RedirectToAction("IndexFileToSql");
        }

        public ActionResult InsertFileToSql()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var collectionCompanyFromFile = DeSerializeObject<List<CompanyModels>>("SerializationOverview");
            dbSQL.CompanyModels.AddRange(collectionCompanyFromFile);

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

            return RedirectToAction("IndexFileToSql");
        }

        public ActionResult UpdateFileToSql()
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

            return RedirectToAction("IndexFileToSql");
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