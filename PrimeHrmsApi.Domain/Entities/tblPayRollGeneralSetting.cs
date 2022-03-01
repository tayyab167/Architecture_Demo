using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPayRollGeneralSetting
    {
        [Key]
        public int intSeqId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public bool? isLateLeaveDeduction { get; set; }
        public bool? isLoan { get; set; }
        public bool? isTaxableBonus { get; set; }
        public bool? isBonus { get; set; }
        [StringLength(50)]
        public string varBonusNameUsed { get; set; }
        public bool? isTaxableBYOD { get; set; }
        public bool? isBYOD { get; set; }
        [StringLength(50)]
        public string varBYODNameUsed { get; set; }
        public bool? isTotalDeduction { get; set; }
        public double? flLateDays { get; set; }
        public double? flDaysDeduction { get; set; }
        [StringLength(100)]
        public string varLateInNameUsed { get; set; }
        public bool? isSameDate { get; set; }
        public bool? isPreviousDate { get; set; }
        public bool? isAllowTaxModel2 { get; set; }
        [StringLength(50)]
        public string TaxApplicableOn { get; set; }
        [StringLength(50)]
        public string varMedicalReimbursementNameUsed { get; set; }
        public bool? isTaxableMedicalReimbursement { get; set; }
        public bool? isMedicalReimbursement { get; set; }
        public bool? isResignEmp { get; set; }
        [StringLength(50)]
        public string varMonthDaysInPayroll { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flFixedDays { get; set; }
        [StringLength(100)]
        public string varLeaveEncashmentNameUsed { get; set; }
        public bool? isTaxableLeaveEncashment { get; set; }
        public bool? isLeaveEncashment { get; set; }
        public int? intPayrollDayFrom { get; set; }
        public int? intPayrollDayTo { get; set; }
        public bool? isDayINTwoMonths { get; set; }
        public bool? isProject { get; set; }
        public bool? isAttendanceMissingA { get; set; }
        public bool? isWdAccordingPayrollIndicator { get; set; }
        public bool? isAllowPayrollFlow { get; set; }
        public bool? isUpdateOverTimeRateButton { get; set; }
        public bool? isLateDed { get; set; }
        public int? intAllowAbsentDaysTotal { get; set; }
        public int? intAjustWorkingDaysManualy { get; set; }
        public bool? isAdjustWorkingDaysManual { get; set; }
        [StringLength(50)]
        public string varCustomColumn5 { get; set; }
        [StringLength(50)]
        public string varCustomColumn6 { get; set; }
        public bool? isCustomColumn5 { get; set; }
        public bool? isCustomColumn6 { get; set; }
        public bool? isCustomColumn5Tax { get; set; }
        public bool? isCustomColumn6Tax { get; set; }
        public bool? isLateFixedDays { get; set; }
        public bool? AdjustAmount { get; set; }
        public bool? isAdjust { get; set; }
        public bool? isRefreshCustomColumn { get; set; }
        public bool? isAllowDailyManualAttendanceDays { get; set; }
        public bool? isAllowSalaryIncrement { get; set; }
        public bool? isShowBLogoForPaySlip { get; set; }
        public int? intPaySlipTempID { get; set; }
        public bool? isBenefitsColHide { get; set; }
        public bool? isBranchDepDesigRefreshValue { get; set; }
        public bool? isOverTimeMultiplyBy { get; set; }
        public double? intOverTimeMultiply { get; set; }
        public double? OvertimeDividedManualWorkingOver { get; set; }
        public bool? isAttendanceAllowanceAllow { get; set; }
        public bool? isAddressInPaySlip { get; set; }
        public bool? isHideOutStandingInPaySlip { get; set; }
        public bool? isBranchWiseAllowance { get; set; }
        public bool? isOTPayrollAutoRefresh { get; set; }
        public bool? isAllowLateDaysNAmount { get; set; }
    }
}
