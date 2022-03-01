using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblBroadAreaDetail
    {
        [Key]
        public int intSeqid { get; set; }
        public int? intBroadId { get; set; }
        [StringLength(4000)]
        public string varTask { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTargetDate { get; set; }
        public int? intTaskCategoryId { get; set; }
        public int? intComplianceStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtComplianceDate { get; set; }
        public int? intQualityWork { get; set; }
        public int? intMasterId { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intRepQualityWork { get; set; }
        public int? intRepComplianceStatus { get; set; }
        public int? intMeetingDeadLines { get; set; }
        public bool? isNextMonthTarget { get; set; }
        public bool? isAllowEditDel { get; set; }
        [StringLength(4000)]
        public string varTargetNote { get; set; }
        [StringLength(4000)]
        public string varComplianceNote { get; set; }
        [StringLength(4000)]
        public string varMonth { get; set; }
        [StringLength(4000)]
        public string varYear { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intManagerId { get; set; }
        public int? intTaskMeasureKPI { get; set; }
        [StringLength(4000)]
        public string varTaskPercentage { get; set; }
        [StringLength(4000)]
        public string varRemarks { get; set; }
        [StringLength(4000)]
        public string varStatus { get; set; }
        public string varGoal { get; set; }
        public string varExecutionPlan { get; set; }
        public string varQuantityMeasure { get; set; }
        [StringLength(4000)]
        public string varType { get; set; }
        [StringLength(4000)]
        public string varDescription { get; set; }
        [StringLength(4000)]
        public string varInnovation { get; set; }
        [StringLength(4000)]
        public string varProcess { get; set; }
        [StringLength(4000)]
        public string varName { get; set; }
        [StringLength(4000)]
        public string varDomain { get; set; }
        [StringLength(4000)]
        public string varMeasureKPI { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intTotalRating { get; set; }
        [StringLength(4000)]
        public string varLeadRemarks { get; set; }
        public double? varQuarterlyPercentage { get; set; }
        [StringLength(4000)]
        public string varRemarksQuarterly { get; set; }
    }
}
