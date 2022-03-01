using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblProvidentFund_Adjustment
    {
        [Key]
        public int intSeqid { get; set; }
        public int? intEmployeeid { get; set; }
        public string varDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationdate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [Key]
        public int intcompanyid { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flDebit { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flCredit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intRefId { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        [StringLength(50)]
        public string PFPayment { get; set; }
    }
}
