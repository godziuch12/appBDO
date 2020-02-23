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
        public string NazwaOperacji { get; set; }
        public string CzasOperacji { get; set; }
        public string BazaDanych { get; set; }
        public DateTime DataOperacji { get; set; }
    }
}