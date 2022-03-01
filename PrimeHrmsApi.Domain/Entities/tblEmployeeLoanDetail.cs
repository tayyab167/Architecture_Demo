using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeLoanDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        public int? intDepartmentId { get; set; }
        public bool? isPaid { get; set; }
        [StringLength(200)]
        public string varType { get; set; }
        public int? intMonth { get; set; }
        public int? intYear { get; set; }
        public double? flPercentage { get; set; }
        public double? flAmount { get; set; }
        public double? flRemaining { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public bool? isCashAdjustment { get; set; }
        public int? varAdjustmentValue { get; set; }
        public double? flPreviousBalance { get; set; }
        public bool? isFreeze { get; set; }
    }
}
