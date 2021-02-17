using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using MySql.Data.MySqlClient;

namespace ApplicationBDO.Controllers
{
    public class CompanySQLMySQLController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private ApplicationDbContextMySQL dbMySQL = new ApplicationDbContextMySQL();

        // DATABASE MySQL ---------------------- SELECT / INSERT / UPDATE / DELETE
        private MySqlConnection connection;
        public CompanySQLMySQLController()
        {
            connection = new MySqlConnection("data source=localhost; port=3306; initial catalog=appBDO; username=root;password=;SslMode=none");
            connection.Open();
        }
        public ActionResult Index()
        {
            //var company = new CompanyModels()
            //{
            //    Country = "Niemcy"
            //};

            //dbMySQL.CompanyModels.Add(company);
            //dbMySQL.SaveChanges();

            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "SQL-MySQL").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            string sql = "SELECT * FROM Company";

            MySqlCommand mySqlCmd = new MySqlCommand(sql, connection);
            var rdr = mySqlCmd.ExecuteReader();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MySQL";
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

            var collectionCompanyFromFile = DeSerializeObject<List<CompanyModels>>("SerializationOverview");

            foreach (var item in collectionCompanyFromFile)
            {
                string sql =
                    "INSERT INTO Company (Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt) " +
                    "VALUES ('" + item.Id + "','" + item.CompanyId + "','" + item.RegistrationNumber + "','" + item.Name + "','" + item.NIP + "','" + item.Pesel + "','" + item.Country + "','" + item.Address + "','" + item.PostalCode + "','" + item.Teryt + "')";
                MySqlCommand mySqlCmd = new MySqlCommand(sql, connection);
                mySqlCmd.ExecuteNonQuery();
            }

            connection.Close();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MySQL";
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

            string update = "UPDATE Company SET Country='Niemcy'";
            MySqlCommand mySqlCmdUpdate = new MySqlCommand(update, connection);
            mySqlCmdUpdate.ExecuteNonQuery();

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MySQL";
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

            string update = "DELETE FROM Company";
            MySqlCommand mySqlCmdUpdate = new MySqlCommand(update, connection);
            mySqlCmdUpdate.ExecuteNonQuery();

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MySQL";
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