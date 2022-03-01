using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblClient
    {
        [Key]
        public int intSeqId { get; set; }
        [Key]
        public int intComapnyId { get; set; }
        [StringLength(50)]
        public string varName { get; set; }
        [StringLength(2000)]
        public string varDesc { get; set; }
        [StringLength(2000)]
        public string varOthers { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public bool? isActive { get; set; }
    }
}
