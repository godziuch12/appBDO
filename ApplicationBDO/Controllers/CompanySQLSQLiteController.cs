using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using System.Data.SqlClient;

namespace ApplicationBDO.Controllers
{
    public class CompanySQLSQLiteController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();

        private string connectionString = "Data Source=sqlite.db";

        // DATABASE SQLLite ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult Index()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "INSERT INTO Company (Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt) " +
                               "VALUES ('test','test1','test2','test3','test4,'test5','test6','test7','test8','test9')";

                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();
            }
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "SQLite").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            string sql = "SELECT * FROM Company";

            //MySqlCommand mySqlCmd = new MySqlCommand(sql, connection);
            //var rdr = mySqlCmd.ExecuteReader();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQLite";
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

            //foreach (var item in collectionCompanyFromFile)
            //{
            //    string sql =
            //        "INSERT INTO Company (Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt) " +
            //        "VALUES ('" + item.Id + "','" + item.CompanyId + "','" + item.RegistrationNumber + "','" + item.Name + "','" + item.NIP + "','" + item.Pesel + "','" + item.Country + "','" + item.Address + "','" + item.PostalCode + "','" + item.Teryt + "')";
            //    MySqlCommand mySqlCmd = new MySqlCommand(sql, connectionString);
            //    mySqlCmd.ExecuteNonQuery();
            //}

            //connection.Close();
            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQLite";
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

            //string update = "UPDATE Company SET Country='Niemcy'";
            //MySqlCommand mySqlCmdUpdate = new MySqlCommand(update, connection);
            //mySqlCmdUpdate.ExecuteNonQuery();

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQLite";
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

            //string update = "DELETE FROM Company";
            //MySqlCommand mySqlCmdUpdate = new MySqlCommand(update, connection);
            //mySqlCmdUpdate.ExecuteNonQuery();

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQLite";
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