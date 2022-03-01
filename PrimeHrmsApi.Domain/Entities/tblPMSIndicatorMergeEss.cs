using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSIndicatorMergeEss
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intManagerId { get; set; }
        public int? intEmployeeID { get; set; }
        [StringLength(50)]
        public string varMonth { get; set; }
        [StringLength(50)]
        public string varYear { get; set; }
        public int? intMailMasterId { get; set; }
        public int? intBroadAreaMasterId { get; set; }
        [StringLength(3050)]
        public string varDescription { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intTotalRating { get; set; }
        public int? intBroadAreaDetailId { get; set; }
        [StringLength(3050)]
        public string varRemarks { get; set; }
        [StringLength(3050)]
        public string varLeadRemarks { get; set; }
        public int? intTotalTime { get; set; }
        [StringLength(400)]
        public string varType { get; set; }
        public bool? isNextMonthTarget { get; set; }
        public bool? isAllowEditDel { get; set; }
        public int? intTaskMeasureKPI { get; set; }
        [StringLength(400)]
        public string varTaskPercentage { get; set; }
        [StringLength(400)]
        public string varStatus { get; set; }
        [StringLength(4000)]
        public string varGoal { get; set; }
        [StringLength(4000)]
        public string varExecutionPlan { get; set; }
        [StringLength(4000)]
        public string varQuantityMeasure { get; set; }
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
        public double? varQuarterlyPercentage { get; set; }
        [StringLength(4000)]
        public string varRemarksQuarterly { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTargetDate { get; set; }
        [StringLength(4000)]
        public string varTask { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(350)]
        public string varLevelType { get; set; }
        public int? intTotalQuestionarySelfRating { get; set; }
        [StringLength(350)]
        public string varTargetNote { get; set; }
        public bool? isLeadUpdated { get; set; }
    }
}
