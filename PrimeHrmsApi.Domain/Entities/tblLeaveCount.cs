using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLeaveCount
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intLeaveTypeId { get; set; }
        public int? intLeaveSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flVal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flhours { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToTime { get; set; }
        [StringLength(50)]
        public string LeaveStatus { get; set; }
        public bool? isAppRejDetail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAppRejDate { get; set; }
        public int? intApprovedBy { get; set; }
        [StringLength(200)]
        public string varDetailAproverej { get; set; }
        public bool? isApprove { get; set; }
    }
}
