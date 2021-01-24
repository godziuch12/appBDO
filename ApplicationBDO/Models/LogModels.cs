using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApplicationBDO.Models
{
    [Table("Log")]
    public class LogModels
    {
        public int Id { get; set; }
        public string OperationName { get; set; }
        public string OperationTime { get; set; }
        public string Database { get; set; }
        public DateTime OperationDate { get; set; }
        public int NumberOfRecords { get; set; }
        public int NumberOfFieldsModel{ get; set; }
        public bool EntityFramework { get; set; }
        public string  NameAPI { get; set; }
    }
}