using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class RequestTrainingForm
    {
        public int? intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDateProposed { get; set; }
        [StringLength(500)]
        public string varRequestWork { get; set; }
        [StringLength(500)]
        public string vartopictraning { get; set; }
        public int? intProposeddays { get; set; }
        [StringLength(500)]
        public string varProposedvenue { get; set; }
        [StringLength(500)]
        public string varParticipentsName { get; set; }
        [StringLength(50)]
        public string intparticipantNumber { get; set; }
        [StringLength(500)]
        public string varTopicsContents { get; set; }
        [StringLength(500)]
        public string varMainTopic { get; set; }
        [StringLength(500)]
        public string varExpectedOutcomes { get; set; }
        [StringLength(500)]
        public string varremarkshod { get; set; }
        [StringLength(500)]
        public string varremarkHR { get; set; }
        [StringLength(500)]
        public string varRemarkExecutiveDirector { get; set; }
        [StringLength(500)]
        public string varremarkSecretary { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToTime { get; set; }
        public int? intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        [StringLength(1000)]
        public string intDepartmentId { get; set; }
        public bool? isApproved { get; set; }
        public int? intApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovalDate { get; set; }
        public bool? isCompletetraning { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTaskTrainingComplete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? toDateTraining { get; set; }
        [StringLength(500)]
        public string varPendingReason { get; set; }
    }
}
