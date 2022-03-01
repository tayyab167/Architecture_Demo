using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSApprovalFlowSave
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMailMasterId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intApprovalId { get; set; }
        public bool? isApprove { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApproveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [StringLength(50)]
        public string varNote { get; set; }
        [StringLength(50)]
        public string varLevelType { get; set; }
        public bool? isShowPrev { get; set; }
        public int? intGoalsMasterId { get; set; }
        [StringLength(500)]
        public string varRemarks { get; set; }
        public double? intTotalTaskRatingSelf { get; set; }
        public double? intTotalTaskRatingLead { get; set; }
        public double? intCountTaskRows { get; set; }
        public double? intCountQuesionaryRows { get; set; }
        public double? intTotalQuestionaryRatingSelf { get; set; }
        public double? intTotalQuestionaryRatingLead { get; set; }
    }
}
