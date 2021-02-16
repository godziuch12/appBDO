using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace ApplicationBDO.Controllers
{
    public class CompanyLoadController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private int numberOfRecrds = 2000000;

        public ActionResult Index()
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
                colection.AddRange(companyList.Select(TranslateCompanyModels));

                n++;
            } while (n < (numberOfRecrds / 10));

            var length = SerializeObject(colection);

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL/NoSQL";
            logs.OperationTime = timeLog;
            logs.OperationName = "LOAD";
            logs.NameAPI = "SearchCompany";
            logs.NumberOfRecords = numberOfRecrds;
            logs.NumberOfFieldsModel = 10;
            logs.SizeFile = length.ToString();
            logs.EntityFramework = true;

            dbSQL.LogModels.Add(logs);
            dbSQL.SaveChanges();

            return RedirectToAction("Index");
        }

        public CompanyModels TranslateCompanyModels(WasteRegisterPublicApiApiModelsElasticsearchCompanyEs companyList)
        {
            return new CompanyModels()
            {
                Id = Guid.NewGuid().ToString(),
                CompanyId = companyList.CompanyId,
                Address = companyList.Address,
                NIP = companyList.Nip,
                Country = companyList.Country,
                PostalCode = companyList.PostalCode,
                RegistrationNumber = companyList.RegistrationNumber,
                Pesel = companyList.Pesel,
                Teryt = companyList.Teryt,
                Name = companyList.Name,
            };
        }

        public long SerializeObject<T>(List<T> serializableObject)
        {
            if (serializableObject == null) { return 0; }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                var path = "C://Users//adria//OneDrive//Pulpit//SerializationOverview.xml";
                FileStream file = System.IO.File.Create(path);
                serializer.Serialize(file, serializableObject);
                file.Close();

                return file.Length;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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