using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblApplyOPDESS
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(50)]
        public string varOPDGrade { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApplyingDate { get; set; }
        [StringLength(2000)]
        public string varDescription { get; set; }
        public double? flAppliedAmount { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [StringLength(50)]
        public string varApproveReject { get; set; }
        [StringLength(1000)]
        public string varfileAttachment { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCompanyID { get; set; }
        public int? intApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovedDate { get; set; }
        public int? intPeriodID { get; set; }
        public double? flAlloatedQuota { get; set; }
        public bool? isPaid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPaidDate { get; set; }
        [StringLength(1000)]
        public string varfileAttachment2 { get; set; }
        [StringLength(1000)]
        public string varfileAttachment3 { get; set; }
        [StringLength(250)]
        public string VarCashBank { get; set; }
    }
}
