using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployementHistory
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [StringLength(500)]
        public string varCompanyName { get; set; }
        [StringLength(3000)]
        public string varJobDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtWorkedFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtWorkedTo { get; set; }
        [StringLength(100)]
        public string varSalary { get; set; }
        [StringLength(3000)]
        public string varReasons { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
