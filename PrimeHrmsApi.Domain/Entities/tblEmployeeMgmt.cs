using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeMgmt
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intWorkingHour { get; set; }
        [StringLength(500)]
        public string varFirstName { get; set; }
        [StringLength(500)]
        public string varLastName { get; set; }
        [StringLength(200)]
        public string varFatherName { get; set; }
        [StringLength(50)]
        public string varExperience { get; set; }
        public int? intDesignation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDateOfBirth { get; set; }
        public int? intSalaryID { get; set; }
        public double? flTotalSalary { get; set; }
        [StringLength(50)]
        public string varEmail { get; set; }
        [StringLength(50)]
        public string varEmailPvt { get; set; }
        [StringLength(1000)]
        public string varAddress1 { get; set; }
        [StringLength(1000)]
        public string varAddress2 { get; set; }
        [StringLength(1500)]
        public string varOthers { get; set; }
        [StringLength(300)]
        public string varImagePath { get; set; }
        public int? intBloodGroupId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intBranchID { get; set; }
        public int? intDepartmentID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLeaveStartPeriod { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLeaveEndPeriod { get; set; }
        [StringLength(50)]
        public string varSex { get; set; }
        [StringLength(100)]
        public string varCNIC { get; set; }
        [StringLength(100)]
        public string varFamily { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCNICExpiry { get; set; }
        [StringLength(100)]
        public string varFatherCNIC { get; set; }
        public int? intReligion { get; set; }
        [StringLength(100)]
        public string varPhone { get; set; }
        [StringLength(100)]
        public string varPermPhone { get; set; }
        [StringLength(1000)]
        public string varMarkOfIdentity { get; set; }
        [StringLength(100)]
        public string varNTN { get; set; }
        [StringLength(100)]
        public string varDrivingLiscNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLiscExpiry { get; set; }
        public int? intLanguage { get; set; }
        [StringLength(100)]
        public string varLivingWith { get; set; }
        public int? intBank { get; set; }
        [StringLength(100)]
        public string varBankAc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtJoiningDate { get; set; }
        public int? intNationality { get; set; }
        public int? intEmployeeType { get; set; }
        public int? intInterView1 { get; set; }
        public int? intInterview2 { get; set; }
        [StringLength(100)]
        public string varGrade { get; set; }
        public double? flExpecSalary { get; set; }
        public double? flBasicSalary { get; set; }
        public double? flGrossSalary { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtHiringDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtConfirmationDate { get; set; }
        [StringLength(100)]
        public string varInsurance { get; set; }
        [StringLength(100)]
        public string varEOBINo { get; set; }
        [StringLength(100)]
        public string varSocialSecurityNo { get; set; }
        [StringLength(1000)]
        public string varMajorIllness { get; set; }
        [StringLength(1000)]
        public string varOtherActivities { get; set; }
        [StringLength(1000)]
        public string varSourceInfo { get; set; }
        [StringLength(100)]
        public string varSuitable { get; set; }
        [StringLength(100)]
        public string varDependent { get; set; }
        [StringLength(100)]
        public string varMarriageWith { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMarriageDate { get; set; }
        [StringLength(100)]
        public string varMarriageNo { get; set; }
        [StringLength(50)]
        public string intShiftID { get; set; }
        public bool? isOverTime { get; set; }
        public int? intStartOver { get; set; }
        public bool? isBasicOverTime { get; set; }
        public bool? isGSOverTime { get; set; }
        public bool? isOverTimeBasicAuto { get; set; }
        public double? flOverTimeBasicPer { get; set; }
        public bool? isOverTimeGSAuto { get; set; }
        public double? flOverTimeGrossPer { get; set; }
        public bool? isOverTimeFixed { get; set; }
        public double? flOverTimeRate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flOverTimeMarkUp { get; set; }
        public bool? isAllowAttendance { get; set; }
        public bool? isAllowClockOut { get; set; }
        public bool? isConfirmed { get; set; }
        public int? intConfirmBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEmployeeConfirmationDate { get; set; }
        [StringLength(500)]
        public string varConfirmationDescription { get; set; }
        public bool? isHod { get; set; }
        public int? intBloodId { get; set; }
        public bool? isActive { get; set; }
        public double? flAttendancePercent { get; set; }
        public bool? isOverTimeHourBase { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtComLeaveDate { get; set; }
        [StringLength(50)]
        public string varPayBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPayReviewDate { get; set; }
        [StringLength(500)]
        public string varPassword { get; set; }
        public bool? isESS { get; set; }
        public int? intReportedTo { get; set; }
        public bool? isEssOnline { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEssActiveDate { get; set; }
        [StringLength(50)]
        public string varMaritalStatus { get; set; }
        [StringLength(50)]
        public string varTaxExmpt { get; set; }
        [StringLength(50)]
        public string varSateCityExmpt { get; set; }
        [StringLength(100)]
        public string varMobilePhone { get; set; }
        public bool? isPrvEmp { get; set; }
        public bool? isI9doc { get; set; }
        public bool? isEverify { get; set; }
        public bool? isW4Complete { get; set; }
        public int? intjobDesID { get; set; }
        public string varJobDesc { get; set; }
        public int? intJobDescription { get; set; }
        public int? intTotalDaysOffAfterPresent { get; set; }
        public int? intTotalDaysOff { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMartialStatusDate { get; set; }
        public int? intAttendanceType { get; set; }
        [StringLength(100)]
        public string varThreshold { get; set; }
        public double? flEmpProvident { get; set; }
        public double? flComProvident { get; set; }
        [StringLength(50)]
        public string varOverTimeType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtContractStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtContractEnd { get; set; }
        [StringLength(50)]
        public string varRTC { get; set; }
        [StringLength(100)]
        public string varReason { get; set; }
        public double? flEmpEOBI { get; set; }
        public double? flComEOBI { get; set; }
        public double? flSocailSecurity { get; set; }
        public double? flSecurity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtContractExpire { get; set; }
        public int? intLeaveHighAuthority { get; set; }
        public bool? isParallelRecommendLeave { get; set; }
        public double? flSecurityInstallment { get; set; }
        public bool? isNoPayroll { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtprobationEndDate { get; set; }
        public string varJobPurpose { get; set; }
        public string varJobKeyRes { get; set; }
        public string varJobWorkingConditions { get; set; }
        public string varJobSkills { get; set; }
        public string varJobQualification { get; set; }
        public string varJobExperience { get; set; }
        public int? intInLimit { get; set; }
        public int? intOldId { get; set; }
        public int? intCareerPath { get; set; }
        public int? intOtherReportedTo { get; set; }
        [StringLength(50)]
        public string varJobGrade { get; set; }
        [StringLength(50)]
        public string varThresholdMaximum { get; set; }
        [StringLength(50)]
        public string varThresholdMinimum { get; set; }
        public bool? isAllowLeaveWithoutQouta { get; set; }
        [StringLength(50)]
        public string varCityBranch { get; set; }
        public int? intLateInRule { get; set; }
        public int? intEarlyOutRule { get; set; }
        [StringLength(50)]
        public string varShortHourType { get; set; }
        public int? intShortHourMarginWeekly { get; set; }
        public bool? isDoubleShiftWD { get; set; }
        public int? intProjectSetupId { get; set; }
        public int? intAttendanceMissingRule { get; set; }
        public bool? isPMSFlowAllow { get; set; }
        public double? flEmployeeEOBI { get; set; }
        public double? flCompanyEOBI { get; set; }
        public bool? isTaxExempt { get; set; }
        public double? flSocialSec { get; set; }
        public bool? isPMSEvaShowToEmp { get; set; }
        public int? flEarlyOutExemptionMints { get; set; }
        public int? intOvertimeOnEachPerMint { get; set; }
        public int? intOverTimeDayPerc { get; set; }
        [StringLength(500)]
        public string varQualificationNew { get; set; }
        [StringLength(200)]
        public string varFleJobDescription { get; set; }
        public bool? isShedulerAllowInEss { get; set; }
        public bool? isAllowDepShift { get; set; }
        public bool? isAllowEmpClockOutModel { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPFStartDate { get; set; }
        public bool? isAnnualCalendarShow { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWeekendOverTimeRatePercent { get; set; }
        public bool? isRoster { get; set; }
        public bool? isRosterRights { get; set; }
        public bool? isChkSperateInOutRow { get; set; }
        [StringLength(200)]
        public string varEmpid { get; set; }
        public bool? isRestDays { get; set; }
        public int? intRestDays { get; set; }
        [StringLength(200)]
        public string varLinkKey { get; set; }
        public bool? isMultipleHeadDepart { get; set; }
        public bool? isLoanTab { get; set; }
        public bool? isRecruitmentTab { get; set; }
        public bool? isEmploymentHistory { get; set; }
        public int? intAttendanceAllowance { get; set; }
        public int? intLateAllowance { get; set; }
        [StringLength(50)]
        public string varbankName { get; set; }
        [StringLength(200)]
        public string CNICImage { get; set; }
        public string varJobDescription { get; set; }
        [StringLength(100)]
        public string varReplacementCode { get; set; }
        public bool? isAllowEarlyIn { get; set; }
        [Column(TypeName = "image")]
        public byte[] varEmployeeImage { get; set; }
        public bool? isMarkWithFace { get; set; }
        public bool? isMarkWithThumb { get; set; }
        public bool? isSendNotificationToEmp { get; set; }
        public double? flOPD { get; set; }
        [StringLength(50)]
        public string varEmployeeCity { get; set; }
        [StringLength(22)]
        public string varRegistrationNo { get; set; }
        public bool? isAdmin { get; set; }
        public int? intAdminCompanyId { get; set; }
        public int? intAdminUserId { get; set; }
        [StringLength(200)]
        public string varInAativeStatus { get; set; }
        [StringLength(50)]
        public string varNoticePeriod { get; set; }
        [StringLength(500)]
        public string varOtherName { get; set; }
        public bool? isHealthInsurance { get; set; }
        [StringLength(150)]
        public string varSkypeID { get; set; }
        [StringLength(150)]
        public string varEmpLunchType { get; set; }
        public bool? isReimbursementTab { get; set; }
        public bool? isAllowReward { get; set; }
        [StringLength(150)]
        public string varJobNumber { get; set; }
        public bool? isAllowEOBIFields { get; set; }
        [StringLength(250)]
        public string varEmployeeSkillLevel { get; set; }
        public bool? isEmployeeSocialSecurity { get; set; }
        [StringLength(250)]
        public string varFatherOccupation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEmployeeEOBIEntry { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEmployeeEOBIExit { get; set; }
        [StringLength(150)]
        public string varBankBranchName { get; set; }
        [StringLength(250)]
        public string varBankBranchAdress { get; set; }
        [StringLength(150)]
        public string varbankBranchCode { get; set; }
        [StringLength(150)]
        public string varIBANNo { get; set; }
        public bool? isEmpManualAttendance { get; set; }
        [StringLength(50)]
        public string varExportData { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtExportDateTime { get; set; }
        [StringLength(250)]
        public string varRoomNo { get; set; }
        [StringLength(250)]
        public string varHostelRent { get; set; }
        [StringLength(250)]
        public string varHostelLocation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtHostelEntryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtHostelLeaveDate { get; set; }
        public int? intEOBIDays { get; set; }
        public bool? isAllowExpensemgmt { get; set; }
        [StringLength(500)]
        public string varEOBITagName { get; set; }
        public int? intHostelLocationID { get; set; }
        public double? flRetentionBonus { get; set; }
        public double? flJoiningBonus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtRetentionExpDate { get; set; }
        public double? flEmpCommitteeFund { get; set; }
        public double? flCompCommitteeFund { get; set; }
        public double? flProbationAmount { get; set; }
        [StringLength(500)]
        public string varTimeZone { get; set; }
        public bool? isMedicalTaxAnnualRule { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMedicalStartDate { get; set; }
        public double? flCarDeduction { get; set; }
        public bool? isAddFine { get; set; }
        public bool? isCompensationOFFDays { get; set; }
        [StringLength(500)]
        public string varFatherNameothers { get; set; }
    }
}
