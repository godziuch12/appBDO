using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApplicationBDO.Models
{
    public class TransmittingMongoModels
    {
        [BsonId]
        public Object Id { get; set; }
        [BsonElement("NIP")]
        public string NIP { get; set; }
        [BsonElement("NumerRejestrowy")]
        public string NumerRejestrowy { get; set; }
        [BsonElement("Adres")]
        public string Adres { get; set; }
        [BsonElement("Nazwa")]
        public string Nazwa { get; set; }
    }
}