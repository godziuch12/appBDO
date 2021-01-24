using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
    public class CompanyController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private MongoDBContext dbNoSQL = new MongoDBContext();
        private IMongoCollection<CompanyMongoModels> companyCollection;

        public CompanyController()
        {
            companyCollection = dbNoSQL.database.GetCollection<CompanyMongoModels>("Company");
        }

        public ActionResult IndexLoadApiToFile()
        {
            return View(dbSQL.LogModels.Where(m => m.OperationName == "LOAD").ToList());
        }

        public ActionResult GetLoadApiToFile()
        {
            var conf = Configuration();

            SearchApi search = new SearchApi(conf);

            var timer = new Stopwatch();
            timer.Start();

            int n = 0;
            var colection = new List<CompanyModels>();
            do
            {
                var companyList = search.SearchCompany("10");
                colection.AddRange(companyList.Select(TranslateCompanyModels).ToList());

                n++;
            } while (n < 100);

            SerializeObject(colection);

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            var timeLog = timeTaken.ToString(@"m\:ss\.fff");

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL/NoSQL";
            logs.OperationTime = timeLog;
            logs.OperationName = "LOAD";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = 1000;
            logs.NumberOfFieldsModel = 1;
            logs.EntityFramework = true;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("IndexLoadApiToFile");
        }

        public ActionResult IndexLoadFileToSql()
        {
            return View(dbSQL.LogModels.Where(m => m.OperationName == "INSERT" && m.Database == "SQL").ToList());
        }

        public ActionResult GetLoadFileToSql()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var collectionCompanyFromFile = DeSerializeObject<List<CompanyModels>>("SerializationOverview");

            foreach (var item in collectionCompanyFromFile)
            {
                companyCollection.InsertOne(new CompanyMongoModels
                {
                    Id = Guid.NewGuid(),
                    CompanyId = item.CompanyId,
                    Address = item.Address,
                    NIP = item.NIP,
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
            logsSQL.OperationDate = DateTime.Now;
            logsSQL.Database = "NoSQL";
            logsSQL.OperationTime = timeLogSQL;
            logsSQL.OperationName = "INSERT";

            dbSQL.LogModels.Add(logsSQL);
            dbSQL.SaveChanges();

            return RedirectToAction("IndexLoadFileToSql");
        }

        public ActionResult IndexLoadFileToNoSql()
        {
            return View(dbSQL.LogModels.Where(m => m.OperationName == "INSERT" && m.Database == "NoSQL").ToList());
        }

        public ActionResult GetLoadFileToNoSql()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            var collectionCompanyFromFile = DeSerializeObject<List<CompanyModels>>("SerializationOverview");

            foreach (var item in collectionCompanyFromFile)
            {
                companyCollection.InsertOne(new CompanyMongoModels
                {
                    Id = Guid.NewGuid(),
                    CompanyId = item.CompanyId,
                    Address = item.Address,
                    NIP = item.NIP,
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
            logsSQL.OperationDate = DateTime.Now;
            logsSQL.Database = "NoSQL";
            logsSQL.OperationTime = timeLogSQL;
            logsSQL.OperationName = "INSERT";

            dbSQL.LogModels.Add(logsSQL);
            dbSQL.SaveChanges();

            return RedirectToAction("IndexLoadFileToNoSql");
        }

        public CompanyModels TranslateCompanyModels(WasteRegisterPublicApiApiModelsElasticsearchCompanyEs companyList)
        {
            return new CompanyModels()
            {
                CompanyId = companyList.CompanyId,
                Address = companyList.Address,
                NIP = companyList.Nip,
                Country = companyList.Country,
                PostalCode = companyList.PostalCode,
                RegistrationNumber = companyList.RegistrationNumber,
                Pesel = companyList.Pesel,
                Teryt = companyList.Teryt
            };
        }

        public void SerializeObject<T>(List<T> serializableObject)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                var path = "C://Users//adria//OneDrive//Pulpit//SerializationOverview.xml";
                FileStream file = System.IO.File.Create(path);
                serializer.Serialize(file, serializableObject);
                file.Close();
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }

        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                //xmlDocument.BaseURI("C://Users//adria//OneDrive//Pulpit");
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
    }
}
