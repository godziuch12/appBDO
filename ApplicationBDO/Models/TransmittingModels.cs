using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApplicationBDO.Models
{
    [Table("Transmitting")]
    public class TransmittingModels
    {
        public int Id { get; set; }
        public string NIP { get; set; }
        public string NumerRejestrowy { get; set; }
        public string Adres { get; set; }
        public string Nazwa { get; set; }
    }
}