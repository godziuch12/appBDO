using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using Microsoft.Ajax.Utilities;
using Raven.Client.Documents;

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
                        var result = session.Query<CompanyModels>();
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

            int numberOfDocumentsPerSession = 10000;

            List<CompanyModels> objectListInChunks = new List<CompanyModels>();

            using (var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080/" },
                Database = "appBDO"
            })
            {
                documentStore.Initialize();
                {
                    for (int i = 0; i < collectionCompanyFromFile.Count; i += numberOfDocumentsPerSession)
                    {
                        using (var session = documentStore.OpenSession())
                        {
                            session.Advanced.MaxNumberOfRequestsPerSession = 1000;
                            var skipCollection = collectionCompanyFromFile.Skip(i).Take(numberOfDocumentsPerSession);
                            skipCollection.ForEach(x => session.Store(x));
                            session.SaveChanges();
                            session.Advanced.Clear();
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

            int numberOfDocumentsPerSession = 10000;

            using (var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080/" },
                Database = "appBDO"
            })
            {
                documentStore.Initialize();
                {
                    var sessionCount = documentStore.OpenSession();
                    var count = sessionCount.Query<CompanyModels>().Count();

                    for (int i = 0; i < count; i += numberOfDocumentsPerSession)
                    {
                        using (var session = documentStore.OpenSession())
                        {
                            session.Advanced.MaxNumberOfRequestsPerSession = 1000;
                            var skipCollection = session.Query<CompanyModels>().Skip(i).Take(numberOfDocumentsPerSession);
                            foreach (var item in skipCollection)
                            {
                                item.Country = "Niemcy";
                            }
                            session.SaveChanges();
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

            int numberOfDocumentsPerSession = 10000;

            using (var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080/" },
                Database = "appBDO"
            })
            {
                documentStore.Initialize();
                {
                    var sessionCount = documentStore.OpenSession();
                    var count = sessionCount.Query<CompanyModels>().Count();

                    for (int i = 0; i < count; i += numberOfDocumentsPerSession)
                    {
                        using (var session = documentStore.OpenSession())
                        {
                            var skipCollection = session.Query<CompanyModels>().Skip(i).Take(numberOfDocumentsPerSession);
                            foreach (var item in skipCollection)
                            {
                                session.Delete(item);
                            }
                            session.SaveChanges();
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
