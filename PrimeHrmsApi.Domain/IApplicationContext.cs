﻿using Microsoft.EntityFrameworkCore;
using PrimeHrmsApi.Domain.Entities;
using System.Threading.Tasks;

namespace PrimeHrmsApi.Domain
{
    public interface IApplicationContext
    {
        DbSet<FAQLeave> FAQLeave { get; set; }
        DbSet<HRMS_company_New> HRMS_company_New { get; set; }
        DbSet<Query_> Query_ { get; set; }
        DbSet<RequestTrainingForm> RequestTrainingForm { get; set; }
        DbSet<tblAdditionalAmount> tblAdditionalAmount { get; set; }
        DbSet<tblAddress> tblAddress { get; set; }
        DbSet<tblAdminCategory> tblAdminCategory { get; set; }
        DbSet<tblAdminDocument> tblAdminDocument { get; set; }
        DbSet<tblAdminDocumentLetterType> tblAdminDocumentLetterType { get; set; }
        DbSet<tblAdminDocumentType> tblAdminDocumentType { get; set; }
        DbSet<tblAdminLogDate> tblAdminLogDate { get; set; }
        DbSet<tblAdminlogin> tblAdminlogin { get; set; }
        DbSet<tblAdminUsers> tblAdminUsers { get; set; }
        DbSet<tblAgeGroup> tblAgeGroup { get; set; }
        DbSet<tblAgreement> tblAgreement { get; set; }
        DbSet<tblAgreementDetail> tblAgreementDetail { get; set; }
        DbSet<tblAlertLog> tblAlertLog { get; set; }
        DbSet<tblAlertsAndNotificationDays> tblAlertsAndNotificationDays { get; set; }
        DbSet<tblAllowanceStructure> tblAllowanceStructure { get; set; }
        DbSet<tblAllowAttendanceEmails> tblAllowAttendanceEmails { get; set; }
        DbSet<tblAllowLeaveType> tblAllowLeaveType { get; set; }
        DbSet<tblAllPages> tblAllPages { get; set; }
        DbSet<tblAnnouncement> tblAnnouncement { get; set; }
        DbSet<tblAnnouncementDetailed> tblAnnouncementDetailed { get; set; }
        DbSet<tblAnnouncementEmail> tblAnnouncementEmail { get; set; }
        DbSet<tblAnualBalance> tblAnualBalance { get; set; }
        DbSet<tblApplyOPDESS> tblApplyOPDESS { get; set; }
        DbSet<tblApplyRoster> tblApplyRoster { get; set; }
        DbSet<tblApplyRosterMaster> tblApplyRosterMaster { get; set; }
        DbSet<tblApprovalOvertime> tblApprovalOvertime { get; set; }
        DbSet<tblAssDesignation> tblAssDesignation { get; set; }
        DbSet<tblAssignmentNew> tblAssignmentNew { get; set; }
        DbSet<tblATSClients> tblATSClients { get; set; }
        DbSet<tblATSFlowEmployee> tblATSFlowEmployee { get; set; }
        DbSet<tblATSFormControl> tblATSFormControl { get; set; }
        DbSet<tblATSGrades> tblATSGrades { get; set; }
        DbSet<tblATSHost> tblATSHost { get; set; }
        DbSet<tblATSInterview> tblATSInterview { get; set; }
        DbSet<tblAtsUserClients> tblAtsUserClients { get; set; }
        DbSet<tblAttendanceAdjustment> tblAttendanceAdjustment { get; set; }
        DbSet<tblAttendanceAllowance> tblAttendanceAllowance { get; set; }
        DbSet<tblAttendanceAllowanceDetail> tblAttendanceAllowanceDetail { get; set; }
        DbSet<tblAttendanceEmailLog> tblAttendanceEmailLog { get; set; }
        DbSet<tblAttendanceInOut> tblAttendanceInOut { get; set; }
        DbSet<tblAttendanceLeaveSummary_Report> tblAttendanceLeaveSummary_Report { get; set; }
        DbSet<tblAttendanceLog> tblAttendanceLog { get; set; }
        DbSet<tblAttendanceLogTemp> tblAttendanceLogTemp { get; set; }
        DbSet<tblAttendanceMissingTemplate> tblAttendanceMissingTemplate { get; set; }
        DbSet<tblAttendanceWatcher> tblAttendanceWatcher { get; set; }
        DbSet<tblAuditLogEmailCheck> tblAuditLogEmailCheck { get; set; }
        DbSet<tblBank> tblBank { get; set; }
        DbSet<tblBankLetterFooter> tblBankLetterFooter { get; set; }
        DbSet<tblBankLetterHeader> tblBankLetterHeader { get; set; }
        DbSet<tblBehaviourChart> tblBehaviourChart { get; set; }
        DbSet<tblBenefit> tblBenefit { get; set; }
        DbSet<tblBenefitAmount> tblBenefitAmount { get; set; }
        DbSet<tblBenefitDetail> tblBenefitDetail { get; set; }
        DbSet<tblBenefitMaster> tblBenefitMaster { get; set; }
        DbSet<tblBillingReimbursement> tblBillingReimbursement { get; set; }
        DbSet<tblBillingRemType> tblBillingRemType { get; set; }
        DbSet<tblBin> tblBin { get; set; }
        DbSet<tblBlog> tblBlog { get; set; }
        DbSet<tblbloodgroup> tblbloodgroup { get; set; }
        DbSet<tblBloodRelation> tblBloodRelation { get; set; }
        DbSet<tblBookPlacement> tblBookPlacement { get; set; }
        DbSet<tblBooks> tblBooks { get; set; }
        DbSet<tblBranch> tblBranch { get; set; }
        DbSet<tblBroadArea> tblBroadArea { get; set; }
        DbSet<tblBroadAreaDetail> tblBroadAreaDetail { get; set; }
        DbSet<tblBroadAreaMaster> tblBroadAreaMaster { get; set; }
        DbSet<tblBusManagement> tblBusManagement { get; set; }
        DbSet<tblCallMgmt> tblCallMgmt { get; set; }
        DbSet<tblCandidateCertification> tblCandidateCertification { get; set; }
        DbSet<tblCandidateEmailLog> tblCandidateEmailLog { get; set; }
        DbSet<tblCandidateExperience> tblCandidateExperience { get; set; }
        DbSet<tblCandidateLog> tblCandidateLog { get; set; }
        DbSet<tblCandidatePost> tblCandidatePost { get; set; }
        DbSet<tblCandidateQualification> tblCandidateQualification { get; set; }
        DbSet<tblCandidateQuestionnaire> tblCandidateQuestionnaire { get; set; }
        DbSet<tblCandidateStatus> tblCandidateStatus { get; set; }
        DbSet<tblCareerPathDetail> tblCareerPathDetail { get; set; }
        DbSet<tblCareerPathMaster> tblCareerPathMaster { get; set; }
        DbSet<tblCatagoryNew> tblCatagoryNew { get; set; }
        DbSet<tblCategory> tblCategory { get; set; }
        DbSet<tblCategoryManagement> tblCategoryManagement { get; set; }
        DbSet<tblCauseNotice> tblCauseNotice { get; set; }
        DbSet<tblCauseNoticeEmployee> tblCauseNoticeEmployee { get; set; }
        DbSet<tblChangeStatus> tblChangeStatus { get; set; }
        DbSet<tblCheckListChild> tblCheckListChild { get; set; }
        DbSet<tblCheckListChildDepartment> tblCheckListChildDepartment { get; set; }
        DbSet<tblCheckListMaster> tblCheckListMaster { get; set; }
        DbSet<tblChildDep> tblChildDep { get; set; }
        DbSet<tblCity> tblCity { get; set; }
        DbSet<tblClass> tblClass { get; set; }
        DbSet<tblClient> tblClient { get; set; }
        DbSet<tblClosing> tblClosing { get; set; }
        DbSet<tblComments> tblComments { get; set; }
        DbSet<tblCommission> tblCommission { get; set; }
        DbSet<tblCommissionESS> tblCommissionESS { get; set; }
        DbSet<tblCommissionType> tblCommissionType { get; set; }
        DbSet<tblCompAlertEmail> tblCompAlertEmail { get; set; }
        DbSet<tblCompany> tblCompany { get; set; }
        DbSet<tblCompanyLetterHeader> tblCompanyLetterHeader { get; set; }
        DbSet<tblCompanyModule> tblCompanyModule { get; set; }
        DbSet<tblCompanyOff> tblCompanyOff { get; set; }
        DbSet<tblCompanyOffMaster> tblCompanyOffMaster { get; set; }
        DbSet<tblCompanyRights> tblCompanyRights { get; set; }
        DbSet<tblCompanyType> tblCompanyType { get; set; }
        DbSet<tblCompAttendanceEmail> tblCompAttendanceEmail { get; set; }
        DbSet<tblCompAttendanceEmailEmployeeList> tblCompAttendanceEmailEmployeeList { get; set; }
        DbSet<tblCompensationAttendance> tblCompensationAttendance { get; set; }
        DbSet<tblCompensationLeave> tblCompensationLeave { get; set; }
        DbSet<tblComplainType> tblComplainType { get; set; }
        DbSet<tblContactDBFormDetail> tblContactDBFormDetail { get; set; }
        DbSet<tblContactDBFormMaster> tblContactDBFormMaster { get; set; }
        DbSet<tblContactLedge> tblContactLedge { get; set; }
        DbSet<tblContactUs> tblContactUs { get; set; }
        DbSet<tblCountry> tblCountry { get; set; }
        DbSet<tblCPR> tblCPR { get; set; }
        DbSet<tblCurrency> tblCurrency { get; set; }
        DbSet<tblCustomAlerts> tblCustomAlerts { get; set; }
        DbSet<tblCustomers> tblCustomers { get; set; }
        DbSet<tblDailyAttendanceAdjustment> tblDailyAttendanceAdjustment { get; set; }
        DbSet<tblDailyManualAllowance> tblDailyManualAllowance { get; set; }
        DbSet<tblDailyManualAttendance> tblDailyManualAttendance { get; set; }
        DbSet<tblDailyManualOT> tblDailyManualOT { get; set; }
        DbSet<tbldashboardComment> tbldashboardComment { get; set; }
        DbSet<tblDashboardSettings> tblDashboardSettings { get; set; }
        DbSet<tblDateOff> tblDateOff { get; set; }
        DbSet<tblDateOffMaster> tblDateOffMaster { get; set; }
        DbSet<tblDaysIndicatorDetail> tblDaysIndicatorDetail { get; set; }
        DbSet<tblDaysIndicatorMaster> tblDaysIndicatorMaster { get; set; }
        DbSet<tblDeduction> tblDeduction { get; set; }
        DbSet<tblDeductionStructure> tblDeductionStructure { get; set; }
        DbSet<tblDeductionType> tblDeductionType { get; set; }
        DbSet<tblDegree> tblDegree { get; set; }
        DbSet<tblDegreeATS> tblDegreeATS { get; set; }
        DbSet<tblDemand> tblDemand { get; set; }
        DbSet<tblDemandApprovalFlowSave> tblDemandApprovalFlowSave { get; set; }
        DbSet<tblDemandApprovalFlowSetUp> tblDemandApprovalFlowSetUp { get; set; }
        DbSet<tblDemandItemDetail> tblDemandItemDetail { get; set; }
        DbSet<tblDemandItemMaster> tblDemandItemMaster { get; set; }
        DbSet<tblDemotion> tblDemotion { get; set; }
        DbSet<tblDep> tblDep { get; set; }
        DbSet<tblDepartment> tblDepartment { get; set; }
        DbSet<tblDepartmentResignEmployee> tblDepartmentResignEmployee { get; set; }
        DbSet<tblDepDocuments> tblDepDocuments { get; set; }
        DbSet<tblDesig> tblDesig { get; set; }
        DbSet<tblDesignation> tblDesignation { get; set; }
        DbSet<tblDetailManualSOP> tblDetailManualSOP { get; set; }
        DbSet<tblDeviceConfig> tblDeviceConfig { get; set; }
        DbSet<tblDeviceTemplate> tblDeviceTemplate { get; set; }
        DbSet<tblDocumentTemplate> tblDocumentTemplate { get; set; }
        DbSet<tblDocumentTypeSetup> tblDocumentTypeSetup { get; set; }
        DbSet<tblDonorContact> tblDonorContact { get; set; }
        DbSet<tblDriver> tblDriver { get; set; }
        DbSet<tblDriverBus> tblDriverBus { get; set; }
        DbSet<tblDriverBusHistory> tblDriverBusHistory { get; set; }
        DbSet<tblDriverManagement> tblDriverManagement { get; set; }
        DbSet<tblEarlyOutAuthorization> tblEarlyOutAuthorization { get; set; }
        DbSet<tblEarlyOutRules> tblEarlyOutRules { get; set; }
        DbSet<tblEarlyOutRulesNew> tblEarlyOutRulesNew { get; set; }
        DbSet<tblEarlyOutRulesNewProcess> tblEarlyOutRulesNewProcess { get; set; }
        DbSet<tblEmail> tblEmail { get; set; }
        DbSet<tblEmailControl> tblEmailControl { get; set; }
        DbSet<tblEmailFooter> tblEmailFooter { get; set; }
        DbSet<tblEmailRecord> tblEmailRecord { get; set; }
        DbSet<tblEmailReminder> tblEmailReminder { get; set; }
        DbSet<tblEmailSetting> tblEmailSetting { get; set; }
        DbSet<tblEmailStatus> tblEmailStatus { get; set; }
        DbSet<tblEmailTemplates> tblEmailTemplates { get; set; }
        DbSet<tblEmpAttendanceLive> tblEmpAttendanceLive { get; set; }
        DbSet<tblEmpContacts> tblEmpContacts { get; set; }
        DbSet<tblEmpDePromotion> tblEmpDePromotion { get; set; }
        DbSet<tblEmpDocuments> tblEmpDocuments { get; set; }
        DbSet<tblEmpExit> tblEmpExit { get; set; }
        DbSet<tblEmpExperience> tblEmpExperience { get; set; }
        DbSet<tblEmpFamilyInfo> tblEmpFamilyInfo { get; set; }
        DbSet<tblEmpFeedback> tblEmpFeedback { get; set; }
        DbSet<tblEmpHealthInsurrance> tblEmpHealthInsurrance { get; set; }
        DbSet<tblEmpIncrements> tblEmpIncrements { get; set; }
        DbSet<tblEmpJobDesc> tblEmpJobDesc { get; set; }
        DbSet<tblEmpLeavesHistory> tblEmpLeavesHistory { get; set; }
        DbSet<tblEmployeeAssignGoal> tblEmployeeAssignGoal { get; set; }
        DbSet<tblEmployeeAssignGoalDetail> tblEmployeeAssignGoalDetail { get; set; }
        DbSet<tblEmployeeAssignGoalDetailSendRequest> tblEmployeeAssignGoalDetailSendRequest { get; set; }
        DbSet<tblEmployeeAssignGoalMsterNew> tblEmployeeAssignGoalMsterNew { get; set; }
        DbSet<tblEmployeeAssociation> tblEmployeeAssociation { get; set; }
        DbSet<tblEmployeeAttendance> tblEmployeeAttendance { get; set; }
        DbSet<tblEmployeeBackgroundCheck> tblEmployeeBackgroundCheck { get; set; }
        DbSet<tblEmployeeCheckListApproved> tblEmployeeCheckListApproved { get; set; }
        DbSet<tblEmployeeChild> tblEmployeeChild { get; set; }
        DbSet<tblEmployeeClearanceCheckListApproved> tblEmployeeClearanceCheckListApproved { get; set; }
        DbSet<tblEmployeeComplains> tblEmployeeComplains { get; set; }
        DbSet<tblEmployeeComplaints> tblEmployeeComplaints { get; set; }
        DbSet<tblEmployeeFields> tblEmployeeFields { get; set; }
        DbSet<tblEmployeeFieldsDtl> tblEmployeeFieldsDtl { get; set; }
        DbSet<tblEmployeeFine> tblEmployeeFine { get; set; }
        DbSet<tblEmployeeItemAssign> tblEmployeeItemAssign { get; set; }
        DbSet<tblEmployeeJobPost> tblEmployeeJobPost { get; set; }
        DbSet<tblEmployeeJobRequest> tblEmployeeJobRequest { get; set; }
        DbSet<tblEmployeeLeaveQouta> tblEmployeeLeaveQouta { get; set; }
        DbSet<tblEmployeeLoanDetail> tblEmployeeLoanDetail { get; set; }
        DbSet<tblEmployeeLoanDetailMerge> tblEmployeeLoanDetailMerge { get; set; }
        DbSet<tblEmployeeLoanMaster> tblEmployeeLoanMaster { get; set; }
        DbSet<tblEmployeeMgmt> tblEmployeeMgmt { get; set; }
        DbSet<tblEmployeeOnBoard> tblEmployeeOnBoard { get; set; }
        DbSet<tblEmployeeOnBoarding> tblEmployeeOnBoarding { get; set; }
        DbSet<tblEmployeeOnBoardingBasicDetails> tblEmployeeOnBoardingBasicDetails { get; set; }
        DbSet<tblEmployeeOnBoardingContactDetails> tblEmployeeOnBoardingContactDetails { get; set; }
        DbSet<tblEmployeeOnBoardingDependantsDetails> tblEmployeeOnBoardingDependantsDetails { get; set; }
        DbSet<tblEmployeeOnBoardingExperienceDetails> tblEmployeeOnBoardingExperienceDetails { get; set; }
        DbSet<tblEmployeeOnBoardingQualificationDetails> tblEmployeeOnBoardingQualificationDetails { get; set; }
        DbSet<tblEmployeeOnBoardingReasons> tblEmployeeOnBoardingReasons { get; set; }
        DbSet<tblEmployeeOvertimeFlow> tblEmployeeOvertimeFlow { get; set; }
        DbSet<tblEmployeeResignFlow> tblEmployeeResignFlow { get; set; }
        DbSet<tblEmployeerQualification> tblEmployeerQualification { get; set; }
        DbSet<tblEmployeeSetting> tblEmployeeSetting { get; set; }
        DbSet<tblEmployeeTransfer> tblEmployeeTransfer { get; set; }
        DbSet<tblEmployeeType> tblEmployeeType { get; set; }
        DbSet<tblEmployementHistory> tblEmployementHistory { get; set; }
        DbSet<tblEmpMedicalTaxHistroy> tblEmpMedicalTaxHistroy { get; set; }
        DbSet<tblEmpPromotion> tblEmpPromotion { get; set; }
        DbSet<tblEmpReferences> tblEmpReferences { get; set; }
        DbSet<tblEmpStatus> tblEmpStatus { get; set; }
        DbSet<tblEobiDays> tblEobiDays { get; set; }
        DbSet<tblEOBIFund> tblEOBIFund { get; set; }
        DbSet<tblEssEmail> tblEssEmail { get; set; }
        DbSet<tblESSEmailContent> tblESSEmailContent { get; set; }
        DbSet<tblEssloginLogout> tblEssloginLogout { get; set; }
        DbSet<tblEssMultipleEmployee> tblEssMultipleEmployee { get; set; }
        DbSet<tblEssNotification> tblEssNotification { get; set; }
        DbSet<tblExceptionDetails> tblExceptionDetails { get; set; }
        DbSet<tblExpenceMgmt> tblExpenceMgmt { get; set; }
        DbSet<tblExpenceMgmtESS> tblExpenceMgmtESS { get; set; }
        DbSet<tblExpenceType> tblExpenceType { get; set; }
        DbSet<tblExpenseDetail> tblExpenseDetail { get; set; }
        DbSet<tblExpenseFlowEmployee> tblExpenseFlowEmployee { get; set; }
        DbSet<tblFAQ> tblFAQ { get; set; }
        DbSet<tblFAQAdvance> tblFAQAdvance { get; set; }
        DbSet<tblFAQAssets> tblFAQAssets { get; set; }
        DbSet<tblFAQAttend> tblFAQAttend { get; set; }
        DbSet<tblFAQESS> tblFAQESS { get; set; }
        DbSet<tblFAQPayroll> tblFAQPayroll { get; set; }
        DbSet<tblFAQReport> tblFAQReport { get; set; }
        DbSet<tblFAQSetup> tblFAQSetup { get; set; }
        DbSet<tblFeeHeads> tblFeeHeads { get; set; }
        DbSet<tblFieldsSetting> tblFieldsSetting { get; set; }
        DbSet<tblFileImage> tblFileImage { get; set; }
        DbSet<tblFinalSettlement> tblFinalSettlement { get; set; }
        DbSet<tblFineType> tblFineType { get; set; }
        DbSet<tblFloaterLeave> tblFloaterLeave { get; set; }
        DbSet<tblFloaterLeaveEmail> tblFloaterLeaveEmail { get; set; }
        DbSet<tblFuel> tblFuel { get; set; }
        DbSet<tblGeneralContacts> tblGeneralContacts { get; set; }
        DbSet<tblGoalsObjectiveDetail> tblGoalsObjectiveDetail { get; set; }
        DbSet<tblGoalsObjectivemaster> tblGoalsObjectivemaster { get; set; }
        DbSet<tblGrades> tblGrades { get; set; }
        DbSet<tblGroupControl> tblGroupControl { get; set; }
        DbSet<tblHelpDeskDetail> tblHelpDeskDetail { get; set; }
        DbSet<tblHelpDeskMaster> tblHelpDeskMaster { get; set; }
        DbSet<tblHelpDeskType> tblHelpDeskType { get; set; }
        DbSet<tblHostelLocation> tblHostelLocation { get; set; }
        DbSet<tblHREmailSetting> tblHREmailSetting { get; set; }
        DbSet<tblIncentive> tblIncentive { get; set; }
        DbSet<tblIncentiveTaxMgmt> tblIncentiveTaxMgmt { get; set; }
        DbSet<tblIncentiveType> tblIncentiveType { get; set; }
        DbSet<tblIncomingCalls> tblIncomingCalls { get; set; }
        DbSet<tblIncrement> tblIncrement { get; set; }
        DbSet<tblIncrementStatus> tblIncrementStatus { get; set; }
        DbSet<tblInstallmentDetail> tblInstallmentDetail { get; set; }
        DbSet<tblInstallmentMaster> tblInstallmentMaster { get; set; }
        DbSet<tblInternetBillReimbursement> tblInternetBillReimbursement { get; set; }
        DbSet<tblInternetBillRemType> tblInternetBillRemType { get; set; }
        DbSet<tblInventory> tblInventory { get; set; }
        DbSet<tblIPS> tblIPS { get; set; }
        DbSet<tblIssueBookDetail> tblIssueBookDetail { get; set; }
        DbSet<tblIssueBookMaster> tblIssueBookMaster { get; set; }
        DbSet<tblIssueDetail> tblIssueDetail { get; set; }
        DbSet<tblIssueMaster> tblIssueMaster { get; set; }
        DbSet<tblItem> tblItem { get; set; }
        DbSet<tblItemCatgory> tblItemCatgory { get; set; }
        DbSet<tblItemIssueDetail> tblItemIssueDetail { get; set; }
        DbSet<tblItemIssueMaster> tblItemIssueMaster { get; set; }
        DbSet<tblItemRate> tblItemRate { get; set; }
        DbSet<tblItemRateCustom> tblItemRateCustom { get; set; }
        DbSet<tblItems> tblItems { get; set; }
        DbSet<tblJobDescription> tblJobDescription { get; set; }
        DbSet<tblJobNumber> tblJobNumber { get; set; }
        DbSet<tblJobPostEmails> tblJobPostEmails { get; set; }
        DbSet<tblJobPostNotify> tblJobPostNotify { get; set; }
        DbSet<tblJobRequest> tblJobRequest { get; set; }
        DbSet<tblJobRequestDetail> tblJobRequestDetail { get; set; }
        DbSet<tblLanguage> tblLanguage { get; set; }
        DbSet<tblLateAllowance> tblLateAllowance { get; set; }
        DbSet<tblLateAllowanceDetail> tblLateAllowanceDetail { get; set; }
        DbSet<tblLateAttendanceExemption> tblLateAttendanceExemption { get; set; }
        DbSet<tblLateEmailControl> tblLateEmailControl { get; set; }
        DbSet<tblLateInAuthorization> tblLateInAuthorization { get; set; }
        DbSet<tblLateInRules> tblLateInRules { get; set; }
        DbSet<tblLateInRulesNew> tblLateInRulesNew { get; set; }
        DbSet<tblLateInRulesNewProcess> tblLateInRulesNewProcess { get; set; }
        DbSet<tblLateInRulesProcess> tblLateInRulesProcess { get; set; }
        DbSet<tblLateInSlabs> tblLateInSlabs { get; set; }
        DbSet<tblLeaveApprovalFlowSave> tblLeaveApprovalFlowSave { get; set; }
        DbSet<tblLeaveApprovalFlowSetUp> tblLeaveApprovalFlowSetUp { get; set; }
        DbSet<tblLeaveCount> tblLeaveCount { get; set; }
        DbSet<tblLeaveEmailCCSetting> tblLeaveEmailCCSetting { get; set; }
        DbSet<tblLeaveEncashment> tblLeaveEncashment { get; set; }
        DbSet<tblLeaves> tblLeaves { get; set; }
        DbSet<tblLeavesPeriod> tblLeavesPeriod { get; set; }
        DbSet<tblLeaveTamplateNew> tblLeaveTamplateNew { get; set; }
        DbSet<tblLeaveTemplateDetail> tblLeaveTemplateDetail { get; set; }
        DbSet<tblLeaveTemplateMaster> tblLeaveTemplateMaster { get; set; }
        DbSet<tblLeaveType> tblLeaveType { get; set; }
        DbSet<tblLetterOfThanksTemplate> tblLetterOfThanksTemplate { get; set; }
        DbSet<tblLoan> tblLoan { get; set; }
        DbSet<tblLoanAjustDetail> tblLoanAjustDetail { get; set; }
        DbSet<tblLoanModuleFlowSetUp> tblLoanModuleFlowSetUp { get; set; }
        DbSet<tblLoanModuleFlowSetUpEmployee> tblLoanModuleFlowSetUpEmployee { get; set; }
        DbSet<tblLoanPurpose> tblLoanPurpose { get; set; }
        DbSet<tblLoanRequest> tblLoanRequest { get; set; }
        DbSet<tblLoanRequestDetail> tblLoanRequestDetail { get; set; }
        DbSet<tblLocation> tblLocation { get; set; }
        DbSet<tblLocationMaster> tblLocationMaster { get; set; }
        DbSet<tblLocationWareHouse> tblLocationWareHouse { get; set; }
        DbSet<tblLog> tblLog { get; set; }
        DbSet<tblLogDate> tblLogDate { get; set; }
        DbSet<tblLoginHistory> tblLoginHistory { get; set; }
        DbSet<tblLubricants> tblLubricants { get; set; }
        DbSet<tblMainContactPerson> tblMainContactPerson { get; set; }
        DbSet<tblMaintance> tblMaintance { get; set; }
        DbSet<tblManagerAuthorised> tblManagerAuthorised { get; set; }
        DbSet<tblManualAtendanceRights> tblManualAtendanceRights { get; set; }
        DbSet<tblManualAttendanceEss> tblManualAttendanceEss { get; set; }
        DbSet<tblManualAttReason> tblManualAttReason { get; set; }
        DbSet<tblManualnSOP> tblManualnSOP { get; set; }
        DbSet<tblManualSOPUpload> tblManualSOPUpload { get; set; }
        DbSet<tblMedicalAllowance> tblMedicalAllowance { get; set; }
        DbSet<tblMedicalOpening> tblMedicalOpening { get; set; }
        DbSet<tblMedicalPeriod> tblMedicalPeriod { get; set; }
        DbSet<tblMenualBreak> tblMenualBreak { get; set; }
        DbSet<tblModuleRights> tblModuleRights { get; set; }
        DbSet<tblModules> tblModules { get; set; }
        DbSet<tblMonths> tblMonths { get; set; }
        DbSet<tblMyMail> tblMyMail { get; set; }
        DbSet<tblNationality> tblNationality { get; set; }
        DbSet<tblNews> tblNews { get; set; }
        DbSet<tblNewsletter> tblNewsletter { get; set; }
        DbSet<tblNotice> tblNotice { get; set; }
        DbSet<tblNumbers> tblNumbers { get; set; }
        DbSet<tblOffBoarding> tblOffBoarding { get; set; }
        DbSet<tblOnBoarding> tblOnBoarding { get; set; }
        DbSet<tblOPDEmployee> tblOPDEmployee { get; set; }
        DbSet<tblOPDGrade> tblOPDGrade { get; set; }
        DbSet<tblOPDHealthPeriod> tblOPDHealthPeriod { get; set; }
        DbSet<tblOPDOpening> tblOPDOpening { get; set; }
        DbSet<tblOPDWithDraw> tblOPDWithDraw { get; set; }
        DbSet<tblOpeningBalance> tblOpeningBalance { get; set; }
        DbSet<tblOpeningEOBI> tblOpeningEOBI { get; set; }
        DbSet<tblOpeningSocailSecurity> tblOpeningSocailSecurity { get; set; }
        DbSet<tblOpeningTax> tblOpeningTax { get; set; }
        DbSet<tblOrderMgmt> tblOrderMgmt { get; set; }
        DbSet<tblOTPGenerator> tblOTPGenerator { get; set; }
        DbSet<tblOverTime> tblOverTime { get; set; }
        DbSet<tblOvertimeApprovalDetail> tblOvertimeApprovalDetail { get; set; }
        DbSet<tblOverTimeApprove> tblOverTimeApprove { get; set; }
        DbSet<tblOverTimeDetail> tblOverTimeDetail { get; set; }
        DbSet<tblOverTimeManual> tblOverTimeManual { get; set; }
        DbSet<tblOverTimeMaster> tblOverTimeMaster { get; set; }
        DbSet<tblOverTimeRequestDetail> tblOverTimeRequestDetail { get; set; }
        DbSet<tblOverTimeRequestMaster> tblOverTimeRequestMaster { get; set; }
        DbSet<tblOvertimeSlabs> tblOvertimeSlabs { get; set; }
        DbSet<tblPages> tblPages { get; set; }
        DbSet<tblParentBillingRemType> tblParentBillingRemType { get; set; }
        DbSet<tblParents> tblParents { get; set; }
        DbSet<tblPayRoll> tblPayRoll { get; set; }
        DbSet<tblPayrollApproval> tblPayrollApproval { get; set; }
        DbSet<tblPayrollBranchPercentage> tblPayrollBranchPercentage { get; set; }
        DbSet<tblPayrollDeletionLocation> tblPayrollDeletionLocation { get; set; }
        DbSet<tblPayRollDetail> tblPayRollDetail { get; set; }
        DbSet<tblPayrollEmailSend> tblPayrollEmailSend { get; set; }
        DbSet<tblPayRollGeneralSetting> tblPayRollGeneralSetting { get; set; }
        DbSet<tblPayrollStructure> tblPayrollStructure { get; set; }
        DbSet<tblPayRollTemplate> tblPayRollTemplate { get; set; }
        DbSet<tblPayrollVerificationFlow> tblPayrollVerificationFlow { get; set; }
        DbSet<tblPerformanceAppraisal> tblPerformanceAppraisal { get; set; }
        DbSet<tblPerformanceAppraisalDetailMonth> tblPerformanceAppraisalDetailMonth { get; set; }
        DbSet<tblPerformanceAppraisalMailMaster> tblPerformanceAppraisalMailMaster { get; set; }
        DbSet<tblPerformanceAppraisalSaveData> tblPerformanceAppraisalSaveData { get; set; }
        DbSet<tblPerformanceApraisalMaster> tblPerformanceApraisalMaster { get; set; }
        DbSet<tblPerformancetemplate> tblPerformancetemplate { get; set; }
        DbSet<tblPerformanceTemplateDetail> tblPerformanceTemplateDetail { get; set; }
        DbSet<tblPlannerTrainingDetail> tblPlannerTrainingDetail { get; set; }
        DbSet<tblPMSAdjustment> tblPMSAdjustment { get; set; }
        DbSet<tblPMSAnalysisData> tblPMSAnalysisData { get; set; }
        DbSet<tblPMSApprovalFlowSave> tblPMSApprovalFlowSave { get; set; }
        DbSet<tblPMSApprovalFlowSetUp> tblPMSApprovalFlowSetUp { get; set; }
        DbSet<tblPMSDateWiseIncrement> tblPMSDateWiseIncrement { get; set; }
        DbSet<tblPMSFooterRemark> tblPMSFooterRemark { get; set; }
        DbSet<tblPMSHistory> tblPMSHistory { get; set; }
        DbSet<tblPMSIncrementHistory> tblPMSIncrementHistory { get; set; }
        DbSet<tblPMSIndicatorMergeEss> tblPMSIndicatorMergeEss { get; set; }
        DbSet<tblPMSMultipleDesignationGradeWise> tblPMSMultipleDesignationGradeWise { get; set; }
        DbSet<tblPMSPage> tblPMSPage { get; set; }
        DbSet<tblPMSPageDetail> tblPMSPageDetail { get; set; }
        DbSet<tblPMSParentIndicator> tblPMSParentIndicator { get; set; }
        DbSet<tblPMSPeriodWise> tblPMSPeriodWise { get; set; }
        DbSet<tblPMSScheduler> tblPMSScheduler { get; set; }
        DbSet<tblPMSTaskCategory> tblPMSTaskCategory { get; set; }
        DbSet<tblPMSTypeNew> tblPMSTypeNew { get; set; }
        DbSet<tblPMSWeitage> tblPMSWeitage { get; set; }
        DbSet<tblPMSWorkConductBase> tblPMSWorkConductBase { get; set; }
        DbSet<tblPOSRecipe> tblPOSRecipe { get; set; }
        DbSet<tblPreQualification> tblPreQualification { get; set; }
        DbSet<tblPreviousSchoolHistory> tblPreviousSchoolHistory { get; set; }
        DbSet<tblProductCategory> tblProductCategory { get; set; }
        DbSet<tblProfit> tblProfit { get; set; }
        DbSet<tblProjectAssign> tblProjectAssign { get; set; }
        DbSet<tblProjectDetails> tblProjectDetails { get; set; }
        DbSet<tblProjects> tblProjects { get; set; }
        DbSet<tblProjectSetup> tblProjectSetup { get; set; }
        DbSet<tblPromotion> tblPromotion { get; set; }
        DbSet<tblProvidentFund> tblProvidentFund { get; set; }
        DbSet<tblProvidentFund_Adjustment> tblProvidentFund_Adjustment { get; set; }
        DbSet<tblprovidentfunds> tblprovidentfunds { get; set; }
        DbSet<tblpublicholidaychild> tblpublicholidaychild { get; set; }
        DbSet<tblpublicHolidayMaster> tblpublicHolidayMaster { get; set; }
        DbSet<tblPurchaseAsset> tblPurchaseAsset { get; set; }
        DbSet<tblPurchaseOrder> tblPurchaseOrder { get; set; }
        DbSet<tblQuesCategory> tblQuesCategory { get; set; }
        DbSet<tblQuestionnaireDetails> tblQuestionnaireDetails { get; set; }
        DbSet<tblQuestionnaireMaster> tblQuestionnaireMaster { get; set; }
        DbSet<tblQuotation> tblQuotation { get; set; }
        DbSet<tblQuotationAdminM> tblQuotationAdminM { get; set; }
        DbSet<tblRack> tblRack { get; set; }
        DbSet<tblReceivedRegisterDetail> tblReceivedRegisterDetail { get; set; }
        DbSet<tblReceptionMgmt> tblReceptionMgmt { get; set; }
        DbSet<tblRefundEOBI> tblRefundEOBI { get; set; }
        DbSet<tblRefundPolicy> tblRefundPolicy { get; set; }
        DbSet<tblReibursmentReportLock> tblReibursmentReportLock { get; set; }
        DbSet<tblReligion> tblReligion { get; set; }
        DbSet<tblReportHeadFooter> tblReportHeadFooter { get; set; }
        DbSet<tblReqTypeDepartment> tblReqTypeDepartment { get; set; }
        DbSet<tblRequestManagement> tblRequestManagement { get; set; }
        DbSet<tblRequestNotes> tblRequestNotes { get; set; }
        DbSet<tblRequestStatusLog> tblRequestStatusLog { get; set; }
        DbSet<tblRequestType> tblRequestType { get; set; }
        DbSet<tblRequestTypeDetail> tblRequestTypeDetail { get; set; }
        DbSet<tblReservedBookDetail> tblReservedBookDetail { get; set; }
        DbSet<tblReservedBookMaster> tblReservedBookMaster { get; set; }
        DbSet<tblResignDetail> tblResignDetail { get; set; }
        DbSet<tblResignEmployee> tblResignEmployee { get; set; }
        DbSet<tblReviewProfile> tblReviewProfile { get; set; }
        DbSet<tblRooms> tblRooms { get; set; }
        DbSet<tblRoster> tblRoster { get; set; }
        DbSet<tblRoutDetail> tblRoutDetail { get; set; }
        DbSet<tblRoutMaster> tblRoutMaster { get; set; }
        DbSet<tblSalary> tblSalary { get; set; }
        DbSet<tblSalaryAdvance> tblSalaryAdvance { get; set; }
        DbSet<tblSaveNotificationEmailRecord> tblSaveNotificationEmailRecord { get; set; }
        DbSet<tblScheduleOfWorks> tblScheduleOfWorks { get; set; }
        DbSet<tblSection> tblSection { get; set; }
        DbSet<tblSecurityRefundable> tblSecurityRefundable { get; set; }
        DbSet<tblSendAbsentEmailRecords> tblSendAbsentEmailRecords { get; set; }
        DbSet<tblSendAnalysisWeeklyEmailRecords> tblSendAnalysisWeeklyEmailRecords { get; set; }
        DbSet<tblSendDailyAttEmailRecords> tblSendDailyAttEmailRecords { get; set; }
        DbSet<tblSendLateEmailRecords> tblSendLateEmailRecords { get; set; }
        DbSet<tblSendMsgToEmployee> tblSendMsgToEmployee { get; set; }
        DbSet<tblSession> tblSession { get; set; }
        DbSet<tblSetting> tblSetting { get; set; }
        DbSet<tblSettingLiveModule> tblSettingLiveModule { get; set; }
        DbSet<tblSettingOT> tblSettingOT { get; set; }
        DbSet<tblShelves> tblShelves { get; set; }
        DbSet<tblShiftChild> tblShiftChild { get; set; }
        DbSet<tblShiftDetail> tblShiftDetail { get; set; }
        DbSet<tblShiftDifference> tblShiftDifference { get; set; }
        DbSet<tblShiftEmployee> tblShiftEmployee { get; set; }
        DbSet<tblShiftLog> tblShiftLog { get; set; }
        DbSet<tblShiftMaster> tblShiftMaster { get; set; }
        DbSet<tblShiftPlaning> tblShiftPlaning { get; set; }
        DbSet<tblShortMinSlabs> tblShortMinSlabs { get; set; }
        DbSet<tblSignature> tblSignature { get; set; }
        DbSet<tblSlotsManagement> tblSlotsManagement { get; set; }
        DbSet<tblSMSDetails> tblSMSDetails { get; set; }
        DbSet<tblSocialSecurity> tblSocialSecurity { get; set; }
        DbSet<tblSocialSecurityDays> tblSocialSecurityDays { get; set; }
        DbSet<tblSparePart> tblSparePart { get; set; }
        DbSet<tblSpouseInfo> tblSpouseInfo { get; set; }
        DbSet<tblState> tblState { get; set; }
        DbSet<tblStockDetail> tblStockDetail { get; set; }
        DbSet<tblstockMaster> tblstockMaster { get; set; }
        DbSet<tblStoreRestdaysOverTime> tblStoreRestdaysOverTime { get; set; }
        DbSet<tblStrengthandAreasImprovement> tblStrengthandAreasImprovement { get; set; }
        DbSet<tblStrengthEmployee> tblStrengthEmployee { get; set; }
        DbSet<tblStudent> tblStudent { get; set; }
        DbSet<tblStudentAttendance> tblStudentAttendance { get; set; }
        DbSet<tblStudentClassSection> tblStudentClassSection { get; set; }
        DbSet<tblStudentHealthHabit> tblStudentHealthHabit { get; set; }
        DbSet<tblStudentteacherBusStop> tblStudentteacherBusStop { get; set; }
        DbSet<tblSubcompany> tblSubcompany { get; set; }
        DbSet<tblSubDep> tblSubDep { get; set; }
        DbSet<tblSubject> tblSubject { get; set; }
        DbSet<tblSupplier> tblSupplier { get; set; }
        DbSet<tblSwapRosterShiftLog> tblSwapRosterShiftLog { get; set; }
        DbSet<tbltagbranch> tbltagbranch { get; set; }
        DbSet<tblTaskCat> tblTaskCat { get; set; }
        DbSet<tblTaskChat> tblTaskChat { get; set; }
        DbSet<tblTaskClient> tblTaskClient { get; set; }
        DbSet<tblTaskClientDetailEmp> tblTaskClientDetailEmp { get; set; }
        DbSet<tblTaskComments> tblTaskComments { get; set; }
        DbSet<tblTaskDateTimeDetail> tblTaskDateTimeDetail { get; set; }
        DbSet<tblTaskDetails> tblTaskDetails { get; set; }
        DbSet<tblTaskEmailCheck> tblTaskEmailCheck { get; set; }
        DbSet<tblTaskEmp> tblTaskEmp { get; set; }
        DbSet<tblTaskLabel> tblTaskLabel { get; set; }
        DbSet<tblTaskMeasurementKPI> tblTaskMeasurementKPI { get; set; }
        DbSet<tblTaskMgmt> tblTaskMgmt { get; set; }
        DbSet<tblTaskMgmtMaster> tblTaskMgmtMaster { get; set; }
        DbSet<tblTaskMgmtSetting> tblTaskMgmtSetting { get; set; }
        DbSet<tblTaskModeration> tblTaskModeration { get; set; }
        DbSet<tblTaskProgressDetail> tblTaskProgressDetail { get; set; }
        DbSet<tblTaskProgressMaster> tblTaskProgressMaster { get; set; }
        DbSet<tblTaskProject> tblTaskProject { get; set; }
        DbSet<tblTaskProjectDetail> tblTaskProjectDetail { get; set; }
        DbSet<tblTaskRating> tblTaskRating { get; set; }
        DbSet<tblTaxAdj> tblTaxAdj { get; set; }
        DbSet<tblTaxCertificationDetail> tblTaxCertificationDetail { get; set; }
        DbSet<tblTaxDetail> tblTaxDetail { get; set; }
        DbSet<tblTaxMaster> tblTaxMaster { get; set; }
        DbSet<tblTeacherMgmt> tblTeacherMgmt { get; set; }
        DbSet<tblTeacherReferences> tblTeacherReferences { get; set; }
        DbSet<tblTeacherSubject> tblTeacherSubject { get; set; }
        DbSet<tblTeamAttendanceRules> tblTeamAttendanceRules { get; set; }
        DbSet<tblTexPeriod> tblTexPeriod { get; set; }
        DbSet<tblTexSlabs> tblTexSlabs { get; set; }
        DbSet<tblTicketDetails> tblTicketDetails { get; set; }
        DbSet<tblTicketMaster> tblTicketMaster { get; set; }
        DbSet<tblTimeSheetDetail> tblTimeSheetDetail { get; set; }
        DbSet<tblTimeSheetMaster> tblTimeSheetMaster { get; set; }
        DbSet<tblTimeTable> tblTimeTable { get; set; }
        DbSet<tblTitleHelpDesk> tblTitleHelpDesk { get; set; }
        DbSet<tbltopoffendsvalue> tbltopoffendsvalue { get; set; }
        DbSet<tblTrainingApprovalFlowSave> tblTrainingApprovalFlowSave { get; set; }
        DbSet<tblTrainingFlowSetUp> tblTrainingFlowSetUp { get; set; }
        DbSet<tblTransferOrder> tblTransferOrder { get; set; }
        DbSet<tblTravel> tblTravel { get; set; }
        DbSet<tblTravelESS> tblTravelESS { get; set; }
        DbSet<tblTravelExpenseDetail> tblTravelExpenseDetail { get; set; }
        DbSet<tblTravelExpenseMaster> tblTravelExpenseMaster { get; set; }
        DbSet<tblUnit> tblUnit { get; set; }
        DbSet<tblUnitManagement> tblUnitManagement { get; set; }
        DbSet<tblUniversities> tblUniversities { get; set; }
        DbSet<tblUserBranches> tblUserBranches { get; set; }
        DbSet<tblUserRights> tblUserRights { get; set; }
        DbSet<tblUserRole> tblUserRole { get; set; }
        DbSet<tblUserRoleRights> tblUserRoleRights { get; set; }
        DbSet<tblUsers> tblUsers { get; set; }
        DbSet<tblUserType> tblUserType { get; set; }
        DbSet<tblVehicalType> tblVehicalType { get; set; }
        DbSet<tblVehicleManagement> tblVehicleManagement { get; set; }
        DbSet<tblVehicleSetup> tblVehicleSetup { get; set; }
        DbSet<tblVendorProduct> tblVendorProduct { get; set; }
        DbSet<tblVendorProducts> tblVendorProducts { get; set; }
        DbSet<tblVendorProductsDetail> tblVendorProductsDetail { get; set; }
        DbSet<tblVersion> tblVersion { get; set; }
        DbSet<tblWarehouseManagement> tblWarehouseManagement { get; set; }
        DbSet<tblWebAdminSettings> tblWebAdminSettings { get; set; }
        DbSet<tblWishes> tblWishes { get; set; }
        DbSet<tblWorkingDays> tblWorkingDays { get; set; }
        DbSet<tblWorkingDaysSlabs> tblWorkingDaysSlabs { get; set; }
        DbSet<viewStock> viewStock { get; set; }
        DbSet<vwEmployee> vwEmployee { get; set; }
        DbSet<vwGetEmployees> vwGetEmployees { get; set; }
        DbSet<vwGetLeavesDetail> vwGetLeavesDetail { get; set; }
        DbSet<wvEmployeeNewView> wvEmployeeNewView { get; set; }

        Task<int> SaveChangesAsync();
    }
}