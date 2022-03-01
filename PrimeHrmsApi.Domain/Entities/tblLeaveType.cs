using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLeaveType
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varAbbr { get; set; }
        [StringLength(100)]
        public string VarName { get; set; }
        [StringLength(1000)]
        public string varDescription { get; set; }
        public bool? isPaid { get; set; }
        public bool? isForward { get; set; }
        [StringLength(50)]
        public string varMaxForwardLeaves { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intBranchID { get; set; }
        public bool? isActive { get; set; }
        public bool? isESS { get; set; }
        public double? flNumDif { get; set; }
        public bool? isApplyToAll { get; set; }
        public bool? isAccordingToJoiningDate { get; set; }
        [StringLength(50)]
        public string varGender { get; set; }
        public bool? isWOQuota { get; set; }
        public int? intMonth { get; set; }
        public bool? isMonthActive { get; set; }
        public bool? isTimeSpecific { get; set; }
        [StringLength(50)]
        public string varSpecHours { get; set; }
        public bool? isMonthlyLeave { get; set; }
        public int? LeavesinMonth { get; set; }
        public bool? isAllowWarning { get; set; }
        public int? intConMonths { get; set; }
        public int? intConMonthsMin { get; set; }
        public int? intPrevDays { get; set; }
        public int? intSpecifyLeaveId { get; set; }
        [StringLength(500)]
        public string varWarningMessage { get; set; }
        public bool? isHideFullHalfQuarterDrp { get; set; }
        public bool? isCanApplyAfterLeavingNotice { get; set; }
        public bool? isSandwichLeave { get; set; }
        public double? flDefaultValueDed { get; set; }
        public bool? is1stHalf2ndHalf { get; set; }
        public bool? isAgainstDate { get; set; }
        public bool? isStopMon { get; set; }
        public bool? isStopTue { get; set; }
        public bool? isStopWed { get; set; }
        public bool? isStopThu { get; set; }
        public bool? isStopFri { get; set; }
        public bool? isStopSat { get; set; }
        public bool? isStopSun { get; set; }
        public double? flDefaultDedMon { get; set; }
        public double? flDefaultDedTue { get; set; }
        public double? flDefaultDedWed { get; set; }
        public double? flDefaultDedThu { get; set; }
        public double? flDefaultDedFri { get; set; }
        public double? flDefaultDedSat { get; set; }
        public double? flDefaultDedSun { get; set; }
        public bool? isLeaveInCash { get; set; }
        public double? flReNewQoutaEveryMonth { get; set; }
        public bool? isHideBloodRelation { get; set; }
        public bool? isShowInLeavecard { get; set; }
        public bool? isShowInLeavecardMust { get; set; }
        public bool? isAccordingToConfirmationDate { get; set; }
        public int? intApproveLeaveAfter { get; set; }
        public bool? ishidebalance { get; set; }
        public bool? isMonthWiseBalance { get; set; }
        [StringLength(250)]
        public string varColor { get; set; }
        public int? intSorting { get; set; }
        public bool? isExtraDaysIncremented { get; set; }
        public int? intLeaveQuotaRenewOnDay { get; set; }
        public bool? chkIsRemoveQuarterleave { get; set; }
    }
}
