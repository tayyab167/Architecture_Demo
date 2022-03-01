using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmailControl
    {
        public int? intSeqId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        public int? intCompanyID { get; set; }
        public bool? chkAttdApp { get; set; }
        public bool? chkPending { get; set; }
        public bool? chkAnalysis { get; set; }
        public bool? chkAbsent { get; set; }
        [StringLength(50)]
        public string varEmailSend { get; set; }
        [StringLength(50)]
        public string varFirstEmail { get; set; }
        [StringLength(50)]
        public string varFirtCC { get; set; }
        [StringLength(50)]
        public string varSecondEmail { get; set; }
        [StringLength(50)]
        public string varSecCC { get; set; }
        [StringLength(50)]
        public string varthrdEmail { get; set; }
        [StringLength(50)]
        public string varthrdCC { get; set; }
        [StringLength(50)]
        public string varFrothEmail { get; set; }
        [StringLength(50)]
        public string varforthCC { get; set; }
        [StringLength(50)]
        public string varFifthCC { get; set; }
        [StringLength(50)]
        public string varfifthEmail { get; set; }
        public bool? chkLate { get; set; }
        public bool? isProbationEndReminder { get; set; }
        public bool? isContractEndReminder { get; set; }
        public bool? isPaidReviewReminder { get; set; }
        public bool? isResignationReminder { get; set; }
        public bool? isDocumentExpiryReminder { get; set; }
        public double? varProbationEndReminder { get; set; }
        public double? varContractEndReminder { get; set; }
        public double? varPaidReviewReminder { get; set; }
        public double? varResignationReminder { get; set; }
        public double? varDocumentExpiryReminder { get; set; }
        public bool? isTeamleadMail { get; set; }
        [StringLength(500)]
        public string varAbsentMsg { get; set; }
        public bool? chkAllowDetail { get; set; }
        public bool? chkAllowSubEmail { get; set; }
        [StringLength(50)]
        public string varTopOffenders { get; set; }
        [StringLength(100)]
        public string varWeeklyMail { get; set; }
        [StringLength(50)]
        public string intMonthlyMail { get; set; }
        [StringLength(50)]
        public string intBiMothFirstMail { get; set; }
        [StringLength(50)]
        public string intBiMothnSecondMail { get; set; }
        [StringLength(50)]
        public string varEmilSubTopOffend { get; set; }
        [StringLength(50)]
        public string varSecLevelReporTopeffend { get; set; }
        public bool? isSecondLevlRep { get; set; }
        public bool? isAllowEssLink { get; set; }
        [StringLength(100)]
        public string varEmailPeriod { get; set; }
        public bool? isEmailDesignTopSummaryBox { get; set; }
        public bool? isEmailOnTime { get; set; }
        [StringLength(20)]
        public string varEmailFromTime { get; set; }
        [StringLength(20)]
        public string varEmailToTime { get; set; }
        public bool? isWeeklyMonToFri { get; set; }
    }
}
