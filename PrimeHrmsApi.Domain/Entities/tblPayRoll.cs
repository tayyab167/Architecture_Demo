using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPayRoll
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmpID { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intWD { get; set; }
        public double? flAtdDed { get; set; }
        public int? intLeaves { get; set; }
        public double? flIncentives { get; set; }
        public double? flDeductions { get; set; }
        public double? flOtherDeductions { get; set; }
        public double? flOtherBonus { get; set; }
        public double? flBasic { get; set; }
        public double? flAdvances { get; set; }
        public double? flBonus { get; set; }
        public double? flTotal { get; set; }
        public int? dtMonth { get; set; }
        public int? dtYear { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intDepartmentID { get; set; }
        public int? intBranchID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDates { get; set; }
        public double? flRate { get; set; }
        public double? flOverTimeHours { get; set; }
        public double? flOtAmount { get; set; }
        public double? flGivenLoanAmount { get; set; }
        public bool? isProcess { get; set; }
        [StringLength(1000)]
        public string flRemarks { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intAdjustDay { get; set; }
        [Column(TypeName = "numeric(18, 1)")]
        public decimal? intWD1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEmailSentOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public bool? isPaid { get; set; }
        public double? flLeavesDed { get; set; }
        public double? flTaxDed { get; set; }
        public double? flLateDed { get; set; }
        public double? flAdvanceSalary { get; set; }
        public double? flShortAttendanceDeduction { get; set; }
        public int? flShortAttendanceDeductionMints { get; set; }
        public double? flProvidentAmount { get; set; }
        public double? flPFLoanDed { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flBYOD { get; set; }
        public double? flEmployeerProvident { get; set; }
        public double? flEmpEOBI { get; set; }
        public double? flComEOBI { get; set; }
        public double? flSocialSecurity { get; set; }
        public double? flSecurity { get; set; }
        public int? intVMasterId { get; set; }
        public double? flLWOPDed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPaidDate { get; set; }
        public double? flMedicalReimbursement { get; set; }
        public double? flAnnualBonus { get; set; }
        public double? flLeaveEncashGrossSal { get; set; }
        public double? flNegativeRemainingSalary { get; set; }
        public double? flArrearsPrevSalary { get; set; }
        public int? intProjectSetupId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flAttendanceMissingRuleAmount { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flBenefits { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? workingDays { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Days1 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? getTotalLate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? LateRuleDayOffEmp { get; set; }
        public bool? isPrepared { get; set; }
        public int? intPreparedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPreparedDate { get; set; }
        public bool? isVerified { get; set; }
        public int? intVerifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtVerifiedDate { get; set; }
        public bool? isApproved { get; set; }
        public int? intApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovedDate { get; set; }
        [Column(TypeName = "numeric(18, 8)")]
        public decimal? flNormalOverTimeRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flNormalOverTimeAdjustmentMint { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flNormalOverTimeMint { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flNormalOverTimeAmount { get; set; }
        [Column(TypeName = "numeric(18, 8)")]
        public decimal? flWeekendOverTimeRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flWeekendOverTimeAdjustmentMint { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flWeekendOverTimeMint { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flWeekendOverTimeAmount { get; set; }
        public bool? isTaxableBonusPayroll { get; set; }
        public bool? isTaxableBYODPayroll { get; set; }
        public bool? isTaxableMedicalReimbursementPayroll { get; set; }
        public bool? isTaxableLeaveEncashmentPayroll { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flOPD { get; set; }
        public int? intDesignationId { get; set; }
        public double? flCustomColumn5 { get; set; }
        public double? flCustomColumn6 { get; set; }
        public double? flAdjustmentAmount { get; set; }
        public double? flAdjustmentDays { get; set; }
        public double? flFixedLateDays { get; set; }
        public double? flNetSalaryAmount { get; set; }
        public double? flEarnedSalaryAmount { get; set; }
        public bool? isAdjustment { get; set; }
        public double? flShortDaysDed { get; set; }
        public double? flShortDaysDedAmount { get; set; }
        public bool? isPFAllowWithIncentive { get; set; }
        [StringLength(50)]
        public string varPayType { get; set; }
        [StringLength(150)]
        public string varBankAccNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBankChangeDate { get; set; }
        public double? flGymAllow { get; set; }
        public double? flPetrolAllowance { get; set; }
        public double? flInternetAllowance { get; set; }
        public double? flLateDaysByRule { get; set; }
        public double? flLateDayAmntByRule { get; set; }
        public double? flTotalWH { get; set; }
        public double? flPerHourSalary { get; set; }
        public double? flEmpCommitteeFund { get; set; }
        public double? flCompCommitteeFund { get; set; }
        public double? flSecurityDed { get; set; }
        public int? intPayrollApprovalId { get; set; }
        public double? flCarDeduction { get; set; }
        public double? flAssestInstallmentDed { get; set; }
    }
}
