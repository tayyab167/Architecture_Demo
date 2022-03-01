using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSalaryAdvance
    {
        [Key]
        public int intSeqid { get; set; }
        public int? intCompanyid { get; set; }
        public int? intEmployeeid { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flAmount { get; set; }
        public string varDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isPaid { get; set; }
        [StringLength(50)]
        public string varMode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPaidDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUnPaidDate { get; set; }
        public int? intPaidBy { get; set; }
        public int? intVMasterId { get; set; }
        public bool? isESS { get; set; }
    }
}
