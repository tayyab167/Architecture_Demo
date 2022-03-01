using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeLeaveQouta
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intLeaveTypeId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intLeaveQouta { get; set; }
        public int? intEmployeeId { get; set; }
        public bool? isForward { get; set; }
        public bool? isPaid { get; set; }
        public int? intMaximumUse { get; set; }
        public int? intMinimumUse { get; set; }
        public int? intUsedLeave { get; set; }
        public int? intBalance { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intPerviousLeaves { get; set; }
        public bool? isForword { get; set; }
        public int? intPeroidid { get; set; }
        public int? varHours { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
    }
}
