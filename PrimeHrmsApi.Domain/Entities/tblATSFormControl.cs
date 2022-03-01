using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblATSFormControl
    {
        [Key]
        public int intSeqId { get; set; }
        public bool? isSalaryRange { get; set; }
        public bool? isAgeRange { get; set; }
        public bool? isIndustry { get; set; }
        public bool? isFatherOccupation { get; set; }
        public bool? isInterviewEndTime { get; set; }
        public bool? isShowQuestionnaire { get; set; }
        public bool? isSendEmailofJobRequest { get; set; }
        public bool? isJobPostForwardEmp { get; set; }
        public bool? isJobNumber { get; set; }
        [StringLength(250)]
        public string varPoweredBy { get; set; }
        public bool? isAppliedJobsSection { get; set; }
        public bool? isSendEmailToCandidate { get; set; }
        public int? intOTPExpiry { get; set; }
        public int? intCompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
    }
}
