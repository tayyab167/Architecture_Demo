using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblExpenceMgmtESS
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intExpenceType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? ExpectedBudget { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? ActualBudget { get; set; }
        public string varDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string isApproveReject { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApproveDate { get; set; }
        [StringLength(50)]
        public string varfileAttachment { get; set; }
        public bool? isPaid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPaidDate { get; set; }
        [StringLength(500)]
        public string varfileAttachment2 { get; set; }
        [StringLength(500)]
        public string varfileAttachment3 { get; set; }
    }
}
