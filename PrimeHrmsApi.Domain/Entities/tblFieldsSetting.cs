using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblFieldsSetting
    {
        public int? intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isBranchtag { get; set; }
        public bool? isJobGrade { get; set; }
        public bool? isPayReview { get; set; }
        public bool? isSecurityLevel { get; set; }
        public bool? isDrivingLisence { get; set; }
        public bool? isExpiryDate { get; set; }
        public bool? isCareerPath { get; set; }
        public bool? isqualifyTab { get; set; }
        public bool? isContactsTab { get; set; }
        public bool? isRefrencetab { get; set; }
        public bool? isJobDecTab { get; set; }
        public bool? isOtherInfo { get; set; }
        public bool? isDependenttab { get; set; }
        public bool? isExperianceTab { get; set; }
        public bool? isReligionField { get; set; }
        public bool? isEarlyOutField { get; set; }
        public bool? isLateInRuleField { get; set; }
        public bool? isQualificationField { get; set; }
        public bool? isMissingAttendanceField { get; set; }
        public bool? isParmanentAddField { get; set; }
        public bool? isEOBIField { get; set; }
        public bool? isBloodGroupField { get; set; }
        public bool? isSocialSecurityField { get; set; }
        public bool? isLivingwithField { get; set; }
        public bool? isLanguageField { get; set; }
        public bool? isPersonalEmailField { get; set; }
        public bool? isIdMarkField { get; set; }
        public bool? isOthersField { get; set; }
        public bool? isCityField { get; set; }
        [StringLength(50)]
        public string varPresentText { get; set; }
        [StringLength(50)]
        public string varAbsentText { get; set; }
        [StringLength(50)]
        public string varDoubleText { get; set; }
        public bool? isEmployeeNumber { get; set; }
        public bool? isCNICValidate { get; set; }
        public bool? isBNotify { get; set; }
        public bool? isANotify { get; set; }
        public bool? isCENotify { get; set; }
        public bool? isPENotify { get; set; }
        public bool? isPRNotify { get; set; }
        public bool? isNJNotify { get; set; }
        public bool? isRegistrationNo { get; set; }
        public bool? isLandLineNumber { get; set; }
        public bool? isProject { get; set; }
        public bool? isTaxNumber { get; set; }
        public bool? isReplacementCode { get; set; }
        public bool? isMainCity { get; set; }
        [StringLength(1000)]
        public string varTeamLeadText { get; set; }
        [StringLength(1050)]
        public string varManagerText { get; set; }
        [StringLength(1050)]
        public string varCNICText { get; set; }
        [StringLength(1050)]
        public string varDesignation { get; set; }
        public bool? isPMSTab { get; set; }
        public bool? isPerformanceTab { get; set; }
        public bool? isLoanTab { get; set; }
        public bool? isBenefitsTab { get; set; }
        public bool? isSettingTab { get; set; }
        public bool? isPayByField { get; set; }
        public bool? isConfirmationDate { get; set; }
        public bool? isShiftTabHide { get; set; }
        public bool? isRulesDivProfile { get; set; }
        public bool? isAttendanceTabHide { get; set; }
        public bool? isPFDateCustom { get; set; }
        [StringLength(1050)]
        public string varShiftTimeName { get; set; }
        [StringLength(1050)]
        public string varPayrollName { get; set; }
        [StringLength(1050)]
        public string varInfoName { get; set; }
        [StringLength(1050)]
        public string isMarriedDateHide { get; set; }
        public bool? isTexCertificate { get; set; }
        public bool? PayrollReportsHide { get; set; }
        [StringLength(50)]
        public string varPFText { get; set; }
        public bool? isNationality { get; set; }
        public bool? isOtherName { get; set; }
        public bool? isTaxProfile { get; set; }
        public bool? isNewOnBoardHide { get; set; }
        public bool? AddImageHide { get; set; }
        public bool? isSkypeId { get; set; }
        public bool? isGenderExpenseHide { get; set; }
        public bool? isPromotionShiftHide { get; set; }
        public bool? isDrpLunchTypeEmp { get; set; }
        public bool? isInCrementNotify { get; set; }
        public bool? isJobNumber { get; set; }
        public bool? isdtContractStart { get; set; }
        public bool? isLoginOnBoarding { get; set; }
        public bool? isEmployeeSkillLevel { get; set; }
        public bool? isFatherOccupation { get; set; }
        public bool? isdtEmployeeEOBIEntry { get; set; }
        public bool? isdtEmployeeEOBIExit { get; set; }
        [StringLength(50)]
        public string varJobGradeName { get; set; }
        [StringLength(50)]
        public string varEmpNo { get; set; }
        [StringLength(50)]
        public string varEmployeeNumber { get; set; }
        [StringLength(50)]
        public string varRegNumber { get; set; }
        public bool? isRoomNo { get; set; }
        public bool? isHostelRent { get; set; }
        public bool? isHostelLocation { get; set; }
        public bool? isdtHostelEntryDate { get; set; }
        public bool? isdtHostelLeaveDate { get; set; }
        public bool? isEOBIdays { get; set; }
        public bool? isEOBITag { get; set; }
        public bool? isJobDescription { get; set; }
        public bool? isflJoiningBonus { get; set; }
        public bool? isflRetentionBonus { get; set; }
        public bool? isEmpCommitteeFund { get; set; }
        public bool? isCompCommitteeFund { get; set; }
        public bool? isflSecurity { get; set; }
        public bool? isflProbationAmount { get; set; }
        public bool? isCarDeduction { get; set; }
    }
}
