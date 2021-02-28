using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Xml.Serialization;
using ApplicationBDO.Models;
using MySql.Data.MySqlClient;

namespace ApplicationBDO.Controllers
{
    public class CompanyMySQLController : Controller
    {
        private ApplicationDbContext dbSQL = new ApplicationDbContext();
        private string _connectionString = "data source=localhost; port=3306; initial catalog=appBDO; username=root;password=;SslMode=none";

        // DATABASE MySQL ---------------------- SELECT / INSERT / UPDATE / DELETE

        public ActionResult Index()
        {
            return View(dbSQL.LogModels.Where(m => (m.OperationName == "SELECT" || m.OperationName == "INSERT" || m.OperationName == "UPDATE" || m.OperationName == "DELETE") && m.Database == "SQL-MySQL").ToList());
        }

        public ActionResult Select()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            string sqlSelect = "SELECT * FROM Company";

            using (MySqlConnection sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(sqlSelect, sqlConnection);
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

            // BULKING 

            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("Id", typeof(string)));
            tbl.Columns.Add(new DataColumn("CompanyId", typeof(string)));
            tbl.Columns.Add(new DataColumn("RegistrationNumber", typeof(string)));
            tbl.Columns.Add(new DataColumn("Name", typeof(string)));
            tbl.Columns.Add(new DataColumn("NIP", typeof(string)));
            tbl.Columns.Add(new DataColumn("Pesel", typeof(string)));
            tbl.Columns.Add(new DataColumn("Country", typeof(string)));
            tbl.Columns.Add(new DataColumn("Address", typeof(string)));
            tbl.Columns.Add(new DataColumn("PostalCode", typeof(string)));
            tbl.Columns.Add(new DataColumn("Teryt", typeof(string)));

            foreach (var item in collectionCompanyFromFile)
            {
                DataRow row = tbl.NewRow();

                row["Id"] = item.Id;
                row["CompanyId"] = item.CompanyId;
                row["RegistrationNumber"] = item.RegistrationNumber;
                row["Name"] = item.Name;
                row["NIP"] = item.NIP;
                row["Pesel"] = item.Pesel;
                row["Country"] = item.Country;
                row["Address"] = item.Address;
                row["PostalCode"] = item.PostalCode;
                row["Teryt"] = item.Teryt;

                tbl.Rows.Add(row);
            }

            using (var sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();

                using (MySqlTransaction tran = sqlConnection.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = sqlConnection;
                        cmd.Transaction = tran;
                        cmd.CommandText = "SELECT * FROM Company";
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.UpdateBatchSize = 1000;
                            using (MySqlCommandBuilder cb = new MySqlCommandBuilder(da))
                            {
                                da.Update(tbl);
                                tran.Commit();
                            }
                        }
                    }
                }
            }

            // WITHOUT BULKING

            //using (MySqlConnection sqlConnection = new MySqlConnection(_connectionString))
            //{
            //    sqlConnection.Open();
            //    foreach (var item in collectionCompanyFromFile)
            //    {
            //        string sqlInsert = "INSERT INTO Company (Id,CompanyId,RegistrationNumber,Name,NIP,Pesel,Country,Address,PostalCode,Teryt) " +
            //                     "VALUES ('" + item.Id + "','" + item.CompanyId + "','" + item.RegistrationNumber + "','" + item.Name + "','" + item.NIP + "','" + item.Pesel + "','" + item.Country + "','" + item.Address + "','" + item.PostalCode + "','" + item.Teryt + "')";

            //        MySqlCommand mySqlCmd = new MySqlCommand(sqlInsert, sqlConnection);
            //        mySqlCmd.ExecuteNonQuery();
            //    }
            //}

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

        //private List<CompanyModels> GetMySqlColumnMapping(DataTable dataTable)
        //{
        //    List<CompanyModels> colMappings = new List<CompanyModels>();
        //    int i = 0;
        //    foreach (DataColumn col in dataTable.Columns)
        //    {
        //        colMappings.Add(new CompanyModels(i, col.ColumnName));
        //        i++;
        //    }
        //    return colMappings;
        //}
        public ActionResult Update()
        {
            var timerSQL = new Stopwatch();
            timerSQL.Start();

            string sqlUpdate = "UPDATE Company SET Country = 'Niemcy'";

            using (MySqlConnection sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(sqlUpdate, sqlConnection);
                mySqlCmd.ExecuteReader();
            }

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

            string sqlDelete = "DELETE FROM Company";

            using (MySqlConnection sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(sqlDelete, sqlConnection);
                mySqlCmd.CommandTimeout = 600;
                mySqlCmd.ExecuteReader();
            }

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