using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using LiteDB;
using MongoDB.Driver;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;

namespace ApplicationBDO.Controllers
{
    [Authorize]
    public class CompanyNoSQLRavenDBController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();

        // DATABASE RAVENDB ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult Index()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "NoSQL-RavenDB").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            using (var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080/" },
                Database = "appBDO"
            })
            {
                documentStore.Initialize();
                {
                    using (var session = documentStore.OpenSession())
                    {
                        var selectCompany = session.Query<CompanyModels>().ToArray();
                    }
                }
            }

            dbSQL.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL-RavenDB";
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

            int numberOfDocumentsPerSession = 1024;  // Chunk size

            List<CompanyModels> objectListInChunks = new List<CompanyModels>();

            using (var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080/" },
                Database = "appBDO"
            })
            {
                documentStore.Initialize();
                {
                    using (var session = documentStore.OpenSession())
                    {
                        session.Advanced.MaxNumberOfRequestsPerSession = 1000;
                        //for (int i = 0; i < collectionCompanyFromFile.Count; i += numberOfDocumentsPerSession)
                        //{
                        //    objectListInChunks.Add(collectionCompanyFromFile.Skip(i).Take(numberOfDocumentsPerSession).ToList());
                        //}

                        //Parallel.ForEach(objectListInChunks, listOfObjects =>
                        //{

                        //    listOfObjects.ForEach(x => session.Store(x));
                        //    session.SaveChanges();
                        //});

                        for (int i = 0; i < collectionCompanyFromFile.Count; i += numberOfDocumentsPerSession)
                        {
                            objectListInChunks.AddRange(collectionCompanyFromFile.Skip(i).Take(numberOfDocumentsPerSession).ToList());
                            objectListInChunks.ForEach(x => session.Store(x));
                            session.SaveChanges();
                            objectListInChunks.Clear();
                        }

                    }
                }
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL-RavenDB";
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
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            using (var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080/" },
                Database = "appBDO"
            })
            {
                documentStore.Initialize();
                {
                    using (var session = documentStore.OpenSession())
                    {
                        var companyUpdate = session.Load<CompanyModels>("country/Polska");

                        companyUpdate.Country = "Niemcy";

                        session.SaveChanges();
                    }
                }
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL-RavenDB";
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

            using (var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080/" },
                Database = "appBDO"
            })
            {
                documentStore.Initialize();
                {
                    using (var session = documentStore.OpenSession())
                    {
                        var selectCompany = session.Query<CompanyModels>().ToArray();

                        session.Delete(selectCompany);
                        session.SaveChanges();
                    }
                }
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL-RavenDB";
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
