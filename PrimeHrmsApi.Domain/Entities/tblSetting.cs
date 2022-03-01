using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSetting
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varSetting { get; set; }
        public bool? IsShiftAuto { get; set; }
        public bool? isOTinPayroll { get; set; }
        [StringLength(100)]
        public string varOTLimit { get; set; }
        [StringLength(100)]
        public string varOTStart { get; set; }
        public double? flLateInHours { get; set; }
        public double? flAbsentPaneltyDay { get; set; }
        public double? flDayOffPresentDay { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isBreakCols { get; set; }
        public bool? isMultiAttendance { get; set; }
        public bool? isShiftCol { get; set; }
        public bool? isShiftSummary { get; set; }
        public bool? isSingleViewLiveAttendance { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLoanModuleDate { get; set; }
        public int? flhours { get; set; }
        [StringLength(100)]
        public string varDeviceName { get; set; }
        [StringLength(50)]
        public string varDeviceIp { get; set; }
        [StringLength(100)]
        public string VarDeviceModel { get; set; }
        public int? flAttendanceRepeatSec { get; set; }
        public bool? isApplyToPayrol { get; set; }
        [StringLength(100)]
        public string varShortMintsCalculationType { get; set; }
        public int? intWeekStartDay { get; set; }
        public double? flComProvident { get; set; }
        public double? flEmpProvident { get; set; }
        public bool? isProvidentFund { get; set; }
        public bool? isEOBI { get; set; }
        public bool? isSocialSecurity { get; set; }
        public bool? isLoanAddToPayrol { get; set; }
        public double? flAdvanceLimit { get; set; }
        public int? flLateExemption { get; set; }
        public int? flEarlyOutExemption { get; set; }
        public int? flEarlyOutExemptionMints { get; set; }
        public int? intTotalLateInMonthEmail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTaxDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPfdate { get; set; }
        public bool? intNotMonthDays { get; set; }
        public bool? isShowManualAttInEss { get; set; }
        public bool? isAllowShortMints { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMarkTillAttendance { get; set; }
        public bool? isAllowGenralExpense { get; set; }
        public bool? isAllowTravelExpense { get; set; }
        public bool? isSecurity { get; set; }
        public bool? chkShortmin { get; set; }
        public bool? chkAddLoan { get; set; }
        public bool? isAttendanceSavingInProcess { get; set; }
        [StringLength(500)]
        public string varPayrollReportName { get; set; }
        [StringLength(500)]
        public string varPayrollPaySlipReportName { get; set; }
        public bool? isOverTime { get; set; }
        public bool? isAccToBreakMin { get; set; }
        public bool? isLeaveApprovalFlow { get; set; }
        public bool? isNHWHShortExces { get; set; }
        public bool? isLeaveTotalBal { get; set; }
        public bool? isSummaryDetailDashboardEss { get; set; }
        public bool? isLeaveFlowBoxEss { get; set; }
        public bool? isAccToOfficeHours { get; set; }
        [StringLength(500)]
        public string varNotificationType { get; set; }
        public bool? isLeaveEmail { get; set; }
        public bool? isClearAttendanceLog { get; set; }
        public bool? isLeaveAppRejOptionTwo { get; set; }
        public bool? isAttfrmFirstDay { get; set; }
        public int? intAttDays { get; set; }
        public bool? isBirthday { get; set; }
        public bool? isJobAnniversary { get; set; }
        public bool? isWeddingAnniversary { get; set; }
        public bool? isLeaveCard { get; set; }
        public bool? isPayroll { get; set; }
        public bool? isPF { get; set; }
        public bool? isLoanLedger { get; set; }
        public bool? isMedicalLedger { get; set; }
        public bool? isTaxStatment { get; set; }
        public bool? isAttAnalysis { get; set; }
        public bool? isManulAttandance { get; set; }
        public bool? isAnalysisTab { get; set; }
        public bool? isOverTimeThreshhold { get; set; }
        public bool? isAttAcctoShift { get; set; }
        public bool? isLeaveCardNewESS { get; set; }
        [StringLength(50)]
        public string varBGColorMain { get; set; }
        [StringLength(50)]
        public string varBGColorInner { get; set; }
        [StringLength(500)]
        public string varBGColorImage { get; set; }
        public bool? isBGImage { get; set; }
        public bool? isAllowOutLimit { get; set; }
        public bool? isloanRestrict { get; set; }
        public bool? isAllowTeamAttinESS { get; set; }
        public bool? isMultiAttDashboard { get; set; }
        public bool? isAllowleaveApply { get; set; }
        public bool? isPMSFlowAllow { get; set; }
        public int? intOvertimeOnEachPerMint { get; set; }
        public bool? LastPMSFlowToEmp { get; set; }
        public bool? isAllowGeneralLeaveCard { get; set; }
        public bool? isAllowClockOutModel { get; set; }
        public bool? isEarlyOutWH { get; set; }
        public bool? isActiveInactiveEmployee { get; set; }
        public bool? isSHLeaveFormula { get; set; }
        public bool? isDuplicateAttendance { get; set; }
        public bool? isTrainingModuleAllow { get; set; }
        public bool? islateAttenAdjustment { get; set; }
        public int? flAttAdjPrevDayLimit { get; set; }
        public int? flLateMultiplyBy { get; set; }
        public bool? isAdvanceSalaryPerct { get; set; }
        public int? intAdvanceSalaryPerct { get; set; }
        public bool? isLoanLimitSalaryPerct { get; set; }
        public int? intLoanLimitSalaryPerct { get; set; }
        public bool? isDailyEmailOfHod { get; set; }
        public bool? isWholeWeekendAsOT { get; set; }
        public bool? isPMSCreateReviewLock { get; set; }
        public bool? isAllowTax { get; set; }
        public bool? isAllowOPD { get; set; }
        public bool? isStockRelated { get; set; }
        public bool? isPerformancenew { get; set; }
        public bool? PMSRelated { get; set; }
        public bool? iscareerPath { get; set; }
        public bool? isManualAttendanceNew { get; set; }
        public bool? isComensateRelatedleave { get; set; }
        public bool? isRosterRelated { get; set; }
        public bool? IsDocumentRelated { get; set; }
        public bool? isPeformancesigal { get; set; }
        public bool? ispayrollShow { get; set; }
        public bool? ComPerformanceAppriasal { get; set; }
        public bool? isMedicalmodul { get; set; }
        public bool? isTaskMgmtShow { get; set; }
        public bool? isSOPShow { get; set; }
        public bool? myTeamNew { get; set; }
        public bool? isLoanModuleTab { get; set; }
        public bool? isLoanModule { get; set; }
        public bool? isApplyFloater { get; set; }
        [StringLength(50)]
        public string varLoanAmountApplied { get; set; }
        [StringLength(50)]
        public string varPeriodofService { get; set; }
        public bool? isGuarantor { get; set; }
        public bool? isLoanAmountApplied { get; set; }
        public bool? isPeriodofService { get; set; }
        [StringLength(50)]
        public string varApplyButton { get; set; }
        [StringLength(50)]
        public string varGuarnteeCount { get; set; }
        public bool? isExemptionoffDays { get; set; }
        public bool? isAbsentNotification { get; set; }
        [StringLength(50)]
        public string varAbsentDays { get; set; }
        public bool? isAllowTaxWRTDOJ { get; set; }
        public bool? isIncrementStatus { get; set; }
        public bool? isOvertimeSlabCheck { get; set; }
        public bool? isAllowteamfunctionality { get; set; }
        public bool? isComplaintMgmt { get; set; }
        public bool? isExpenseMgmt { get; set; }
        public bool? isShowReportedEmp { get; set; }
        public bool? isEmpDropShowESS { get; set; }
        public bool? isEditleaveOption { get; set; }
        public bool? isOtherReviewPMS { get; set; }
        public bool? isAllowOvertimeDays30 { get; set; }
        public bool? isEmploymentHistory { get; set; }
        public double? flBreakMin { get; set; }
        public double? flDutyTimePercentage { get; set; }
        public bool? IsManualAttenApproveAuto { get; set; }
        public bool? isManualAttendancePreveiosApply { get; set; }
        public bool? isManualAttendFutureApply { get; set; }
        public int? intLimitTimeApplyManualAtt { get; set; }
        public bool? intLimitCheckManual { get; set; }
        public double? flFixedWH { get; set; }
        public bool? isSMMergeIntoOT { get; set; }
        public int? intTimeLimitManualPrevious { get; set; }
        public bool? isTimielimitPreviousmanual { get; set; }
        public int? intTimeLimitFutureManual { get; set; }
        public bool? isTimeLimitfutureManual { get; set; }
        public int? intAlertsNotificationDays { get; set; }
        public bool? isInactiveEmpAttMissing { get; set; }
        [StringLength(3)]
        public string varInactiveEmpAttMissingDays { get; set; }
        public bool? isSanwichOnAbsnet { get; set; }
        public bool? isEditableProfile { get; set; }
        public bool? isRememberESSPassword { get; set; }
        public bool? isJobDescriptionInEss { get; set; }
        public bool? isGoalsObjective { get; set; }
        public bool? isATSTab { get; set; }
        public bool? isWHStandardTime { get; set; }
        public bool? isJobRequest { get; set; }
        public bool? isChangeStatusFormNew { get; set; }
        public bool? isPayrollGraphNew { get; set; }
        public bool? isJobView { get; set; }
        public bool? isHelpDeskESS { get; set; }
        public bool? isSendNotification { get; set; }
        public bool? isDblRowDelOnNull { get; set; }
        public bool? ispayrollDateWise { get; set; }
        public bool? isInOutOnSeprateMachines { get; set; }
        public bool? isEditFinalSettlement { get; set; }
        public bool? isSlabWorkingDays { get; set; }
        public bool? isManualAttPopUpAppear { get; set; }
        public double? flMaxPopUp { get; set; }
        public double? flMinPopUp { get; set; }
        public bool? isPersonalEmailSending { get; set; }
        public bool? isAutoApprovePreviousDate { get; set; }
        public bool? isMarkClockOutOnLogout { get; set; }
        public bool? isEmployeeAttendanceUpdate { get; set; }
        public bool? isAllowTypeWiseApplyLeaveDropdown { get; set; }
        public int? intPMSDropDownValues { get; set; }
        public int? intPMScountStrt { get; set; }
        public int? isAllowTaskDoubleRow { get; set; }
        public bool? isOTHoursShow { get; set; }
        public bool? isMaxAutoEmpActive { get; set; }
        public bool? isOPDDeduct { get; set; }
        public bool? isPMSPrevGoals { get; set; }
        public bool? isCheckListActive { get; set; }
        public bool? isChckAbsentLeave { get; set; }
        public bool? isEditableName { get; set; }
        public bool? isEditableEmail { get; set; }
        public bool? isEditablePhone { get; set; }
        public bool? isEditableMaritalStatus { get; set; }
        public bool? isEditableAddress { get; set; }
        public bool? isPFAllowWithIncentive { get; set; }
        public bool? isChckBillingRem { get; set; }
        public bool? isCheckTimeValidation { get; set; }
        public bool? isChckShowPMSEvaToEmp { get; set; }
        public bool? isshowManagerEmp { get; set; }
        public bool? isGridViewEmp { get; set; }
        public bool? isEditableEmergencyContact { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtSendBirthDayTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtSendAnniversaryTime { get; set; }
        public bool? isShowBankinESS { get; set; }
        public bool? isEditBankName { get; set; }
        public bool? isEditAccountNo { get; set; }
        public bool? isEditBankBranch { get; set; }
        public bool? isEditBankAddress { get; set; }
        public bool? isEditBankCode { get; set; }
        public bool? isEditBankIBAN { get; set; }
        public bool? isApplyOPDMgmt { get; set; }
        public bool? isImageApproval { get; set; }
        public double? flOvertimeAttAdjustmentLimit { get; set; }
        public bool? isApplyExpenseFlow { get; set; }
        public bool? isProRatedPF { get; set; }
        public bool? isSendEmailOPD { get; set; }
        public bool? isSendEmailExpense { get; set; }
        public bool? isApplyResign { get; set; }
        public bool? isApplyAdvances { get; set; }
        public int? intInactiveDays { get; set; }
        public int? intActiveDays { get; set; }
        public bool? isMakeEmpActiveInactive { get; set; }
        public bool? isFromAttendanceFetchPage { get; set; }
        public bool? isWarningEmailCount { get; set; }
        public bool? isFineListTab { get; set; }
        public bool? isManualAttDepartmentWise { get; set; }
        public bool? isSendEmailResign { get; set; }
        public bool? isOTESSApproval { get; set; }
        public bool? isMyMail { get; set; }
        public bool? isAssestInstallment { get; set; }
    }
}
