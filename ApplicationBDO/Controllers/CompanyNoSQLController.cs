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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using MongoDB.Driver;

namespace ApplicationBDO.Controllers
{
    [Authorize]
    public class CompanyNoSQLController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private MongoDBContext dbNoSQL = new MongoDBContext();
        private IMongoCollection<CompanyMongoModels> companyCollection;
        private int numberOfRecrds = 100000;

        public CompanyNoSQLController()
        {
            companyCollection = dbNoSQL.database.GetCollection<CompanyMongoModels>("Company");
        }


        // DATABASE MONGODB ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult Index()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "NoSQL").ToList());
        }

        public async Task<ActionResult> Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var selectCompany = await companyCollection.Find(f => true).ToListAsync();

            dbSQL.SaveChanges();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL";
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

            var collectionCompanyFromFile = DeSerializeObject<List<CompanyModels>>("SerializationOverview");

            foreach (var item in collectionCompanyFromFile)
            {
                companyCollection.InsertOne(new CompanyMongoModels
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

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL";
            logs.OperationTime = timeLog;
            logs.OperationName = "INSERT";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = 1000;
            logs.NumberOfFieldsModel = 1;
            logs.EntityFramework = true;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Update()
        {   
            var update = Builders<CompanyMongoModels>.Update.Set(s => s.Country, "Anglia");

            var timerSQL = new Stopwatch();
            timerSQL.Start();

            await companyCollection.UpdateManyAsync( _ => true, update);

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL";
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

        public async Task<ActionResult> Delete()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            await companyCollection.DeleteManyAsync(_ => true);

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "NoSQL";
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
