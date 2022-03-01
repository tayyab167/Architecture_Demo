using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmailReminder
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        public int? intCompanyID { get; set; }
        public bool? isProbationEndReminder { get; set; }
        public bool? isContractEndReminder { get; set; }
        public bool? isPaidReviewReminder { get; set; }
        public bool? isResignationReminder { get; set; }
        public bool? isDocumentExpiryReminder { get; set; }
        public double? flProbationEndReminder { get; set; }
        public double? flContractEndReminder { get; set; }
        public double? flPaidReviewReminder { get; set; }
        public double? flResignationReminder { get; set; }
        public double? flDocumentExpiryReminder { get; set; }
        [StringLength(500)]
        public string varProbationEndReminderTo { get; set; }
        [StringLength(500)]
        public string varContractEndReminderTo { get; set; }
        [StringLength(500)]
        public string varPaidReviewReminderTo { get; set; }
        [StringLength(500)]
        public string varResignationReminderTo { get; set; }
        [StringLength(500)]
        public string varDocumentExpiryReminderTo { get; set; }
    }
}
