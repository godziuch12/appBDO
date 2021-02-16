using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationBDO.Models
{
    [Table("Company")]
    public class CompanyModels
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public string Pesel { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Teryt { get; set; }
    }
}