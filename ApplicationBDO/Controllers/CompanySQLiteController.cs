using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using System.Data.SQLite;

namespace ApplicationBDO.Controllers
{
    public class CompanySQLiteController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private string _connectionString = @"Data Source=C:\temp\SQLite.db;";

        // DATABASE SQLLite ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult Index()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "SQL-SQLite").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            string sqlSelect = "SELECT * FROM Company";

            using (SQLiteConnection sqlConnection = new SQLiteConnection(_connectionString))
            {
                sqlConnection.Open();
                SQLiteCommand mySqlCmd = new SQLiteCommand(sqlSelect, sqlConnection);
                var result = mySqlCmd.ExecuteReader();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-SQLite";
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

            // BULKING 

            using (SQLiteConnection sqlConnection = new SQLiteConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SQLiteCommand(sqlConnection))
                {
                    using (var transaction = sqlConnection.BeginTransaction())
                    {
                        foreach (var item in collectionCompanyFromFile)
                        {
                            sqlCmd.CommandText =
                                "INSERT INTO Company (Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt) " +
                                "VALUES ('" + item.Id + "','" + item.CompanyId + "','" + item.RegistrationNumber +
                                "','" +
                                item.Name + "','" + item.NIP + "','" + item.Pesel + "','" + item.Country + "','" +
                                item.Address + "','" + item.PostalCode + "','" + item.Teryt + "')";
                            sqlCmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
            }

            // WITHOUT BULKING

            //using (SQLiteConnection sqlConnection = new SQLiteConnection(_connectionString))
            //{
            //    sqlConnection.Open();
            //    foreach (var item in collectionCompanyFromFile)
            //    {
            //        string query = "INSERT INTO Company (Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt) " +
            //                       "VALUES ('" + item.Id + "','" + item.CompanyId + "','" + item.RegistrationNumber + "','" + item.Name + "','" + item.NIP + "','" + item.Pesel + "','" + item.Country + "','" + item.Address + "','" + item.PostalCode + "','" + item.Teryt + "')";

            //        SQLiteCommand sqlCmd = new SQLiteCommand(query, sqlConnection);
            //        sqlCmd.ExecuteNonQuery();
            //    }
            //}

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-SQLite";
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

            string sqlUpdate = "UPDATE Company SET Country = 'Niemcy'";
            using (SQLiteConnection sqlConnection = new SQLiteConnection(_connectionString))
            {
                sqlConnection.Open();
                SQLiteCommand mySqlCmd = new SQLiteCommand(sqlUpdate, sqlConnection);
                mySqlCmd.ExecuteNonQuery();
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-SQLite";
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

            string sqlDelete = "DELETE FROM Company";
            using (SQLiteConnection sqlConnection = new SQLiteConnection(_connectionString))
            {
                sqlConnection.Open();
                SQLiteCommand mySqlCmd = new SQLiteCommand(sqlDelete, sqlConnection);
                mySqlCmd.ExecuteNonQuery();
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-SQLite";
            logs.OperationTime = timeLog;
            logs.OperationName = "DELETE";
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