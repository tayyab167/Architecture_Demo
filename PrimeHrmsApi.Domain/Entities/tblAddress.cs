using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAddress
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [StringLength(1000)]
        public string varAddress { get; set; }
        [StringLength(200)]
        public string varCity { get; set; }
        [StringLength(200)]
        public string varCountry { get; set; }
        [StringLength(100)]
        public string varPhone { get; set; }
        [StringLength(100)]
        public string varPhone2 { get; set; }
        [StringLength(100)]
        public string varEmail { get; set; }
        public bool? IsMain { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreation { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdate { get; set; }
        public int? intUpdatedby { get; set; }
    }
}
