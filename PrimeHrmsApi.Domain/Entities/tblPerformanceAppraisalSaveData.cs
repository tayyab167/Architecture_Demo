using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPerformanceAppraisalSaveData
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(2050)]
        public string varComment { get; set; }
        public int? intMasterId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varRating { get; set; }
        public bool? issubmit { get; set; }
        public int? intSetid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intFilledBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtfilledDate { get; set; }
        public int? intSendTo { get; set; }
        public int? intClientid { get; set; }
        public int? intManageID { get; set; }
        public int? intParentId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtManualCreationDate { get; set; }
        [StringLength(2050)]
        public string varRemarks { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varTiming { get; set; }
        public int? intPID { get; set; }
        public int? intPMID { get; set; }
        [StringLength(300)]
        public string varRemarksGoals { get; set; }
        public int? intManagerFlowId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varManagerRating { get; set; }
        public bool? isManagerSubmit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtmanagerFilledDate { get; set; }
        [StringLength(250)]
        public string varManagerRemarks { get; set; }
    }
}
