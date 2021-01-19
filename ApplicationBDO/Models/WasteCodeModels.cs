using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApplicationBDO.Models
{
    [Table("WasteCode")]
    public class WasteCodeModels
    {
        public int Id { get; set; }
        public int? WasteCodeId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? IsDangerous { get; set; }
        public bool? Deleted { get; set; }
        public int? Level { get; set; }
        public int? ParentId { get; set; }
    }
}