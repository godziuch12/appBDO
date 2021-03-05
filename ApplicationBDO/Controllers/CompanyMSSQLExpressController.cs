using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using ApplicationBDO.Models;

namespace ApplicationBDO.Controllers
{
    public class CompanyMSSQLExpressController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private string _connectionString = "data source=DESKTOP-4I4A5QQ\\SQLEXPRESS;initial catalog=ApplicationBDO;Integrated Security=SSPI;persist security info=True;";

        // DATABASE MSSQLExpress ---------------------- SELECT / INSERT / UPDATE / DELETE}

        public ActionResult Index()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "SQL-MSSQLExpress").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            //// NOTRACING

            //var listNoTracing = dbSQL.CompanyModels.AsNoTracking();

            //foreach (var item in listNoTracing)
            //{
            //    Console.WriteLine(item);
            //}

            //// TRACING

            //var listTracing = dbSQL.CompanyModels;

            //foreach (var item in listTracing)
            //{
            //    Console.WriteLine(item);
            //}

            // QUERY 

            string sqlSelect = "SELECT * FROM Company";

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConnection);
                var result = sqlCmd.ExecuteReader();

                foreach (var item in result)
                {
                    Console.WriteLine(result);
                }
            }

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MSSQLExpress";
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

            //DataTable tbl = new DataTable();
            //tbl.Columns.Add(new DataColumn("Id", typeof(string)));
            //tbl.Columns.Add(new DataColumn("CompanyId", typeof(string)));
            //tbl.Columns.Add(new DataColumn("RegistrationNumber", typeof(string)));
            //tbl.Columns.Add(new DataColumn("Name", typeof(string)));
            //tbl.Columns.Add(new DataColumn("NIP", typeof(string)));
            //tbl.Columns.Add(new DataColumn("Pesel", typeof(string)));
            //tbl.Columns.Add(new DataColumn("Country", typeof(string)));
            //tbl.Columns.Add(new DataColumn("Address", typeof(string)));
            //tbl.Columns.Add(new DataColumn("PostalCode", typeof(string)));
            //tbl.Columns.Add(new DataColumn("Teryt", typeof(string)));

            //foreach (var item in collectionCompanyFromFile)
            //{
            //    DataRow row = tbl.NewRow();

            //    row["Id"] = item.Id;
            //    row["CompanyId"] = item.CompanyId;
            //    row["RegistrationNumber"] = item.RegistrationNumber;
            //    row["Name"] = item.Name;
            //    row["NIP"] = item.NIP;
            //    row["Pesel"] = item.Pesel;
            //    row["Country"] = item.Country;
            //    row["Address"] = item.Address;
            //    row["PostalCode"] = item.PostalCode;
            //    row["Teryt"] = item.Teryt;

            //    tbl.Rows.Add(row);
            //}

            //using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            //{
            //    sqlConnection.Open();

            //    SqlBulkCopy objbulk = new SqlBulkCopy(sqlConnection);
            //    objbulk.BulkCopyTimeout = 60;

            //    objbulk.DestinationTableName = "dbo.Company";
            //    objbulk.ColumnMappings.Add("Id", "Id");
            //    objbulk.ColumnMappings.Add("CompanyId", "CompanyId");
            //    objbulk.ColumnMappings.Add("RegistrationNumber", "RegistrationNumber");
            //    objbulk.ColumnMappings.Add("Name", "Name");
            //    objbulk.ColumnMappings.Add("NIP", "NIP");
            //    objbulk.ColumnMappings.Add("Pesel", "Pesel");
            //    objbulk.ColumnMappings.Add("Country", "Country");
            //    objbulk.ColumnMappings.Add("Address", "Address");
            //    objbulk.ColumnMappings.Add("PostalCode", "PostalCode");
            //    objbulk.ColumnMappings.Add("Teryt", "Teryt");

            //    objbulk.WriteToServer(tbl);
            //}

            // WITHOUT BULKING

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                foreach (var item in collectionCompanyFromFile)
                {
                    string sqlInsert = "INSERT INTO Company (Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt) " +
                                       "VALUES ('" + item.Id + "','" + item.CompanyId + "','" + item.RegistrationNumber + "','" +
                                       item.Name + "','" + item.NIP + "','" + item.Pesel + "','" + item.Country + "','" +
                                       item.Address + "','" + item.PostalCode + "','" + item.Teryt + "')";

                    SqlCommand sqlCmd = new SqlCommand(sqlInsert, sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                }
            }


            dbSQL.CompanyModels.Add(new CompanyModels() { Id = "2", Country = "Polska" });
            dbSQL.SaveChanges();

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MSSQLExpress";
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

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                string sqlUpdate = "UPDATE Company SET Country = 'Niemcy'";
                SqlCommand sqlCmd = new SqlCommand(sqlUpdate, sqlConnection);
                sqlCmd.ExecuteNonQuery();
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MSSQLExpress";
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

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                string sqlDelete = "DELETE FROM Company";
                SqlCommand sqlCmd = new SqlCommand(sqlDelete, sqlConnection);
                sqlCmd.ExecuteNonQuery();
            }

            timerSQL.Stop();

            TimeSpan timeTaken = timerSQL.Elapsed;
            var timeLog = timeTaken.ToString();

            var logs = new LogModels();
            logs.OperationDate = DateTime.Now;
            logs.Database = "SQL-MSSQLExpress";
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