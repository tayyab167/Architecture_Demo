using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmailStatus
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intEmployeeId { get; set; }
        public bool? isLeave { get; set; }
        public bool? isPayslip { get; set; }
        public bool? isLoan { get; set; }
        public bool? isMessage { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public bool? isEmailAttSummaryToTeamLead { get; set; }
        public bool? isEmailAttApprovalToTeamLead { get; set; }
        public bool? isEmailOfLateIn { get; set; }
        public bool? isAbsent { get; set; }
        public bool? isEmailDaily { get; set; }
        public bool? istask { get; set; }
        public bool? isEmailAnalysisWeekly { get; set; }
        public bool? isAllowAndroidAppInEmail { get; set; }
        [StringLength(250)]
        public string varEmailAbsent { get; set; }
        [StringLength(250)]
        public string varEmailWeekly { get; set; }
        [StringLength(250)]
        public string varEmailMonthlyLate { get; set; }
        public bool? isAllowOutLimit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? txtOutLimit { get; set; }
        public bool? isAllowLeaveWithoutQouta { get; set; }
    }
}
