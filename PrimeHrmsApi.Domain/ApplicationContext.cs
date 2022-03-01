using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PrimeHrmsApi.Domain.Entities;
// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain
{
    public partial class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
        public virtual DbSet<FAQLeave> FAQLeave { get; set; }
        public virtual DbSet<HRMS_company_New> HRMS_company_New { get; set; }
        public virtual DbSet<Query_> Query_ { get; set; }
        public virtual DbSet<RequestTrainingForm> RequestTrainingForm { get; set; }
        public virtual DbSet<tblATSClients> tblATSClients { get; set; }
        public virtual DbSet<tblATSFlowEmployee> tblATSFlowEmployee { get; set; }
        public virtual DbSet<tblATSFormControl> tblATSFormControl { get; set; }
        public virtual DbSet<tblATSGrades> tblATSGrades { get; set; }
        public virtual DbSet<tblATSHost> tblATSHost { get; set; }
        public virtual DbSet<tblATSInterview> tblATSInterview { get; set; }
        public virtual DbSet<tblAdditionalAmount> tblAdditionalAmount { get; set; }
        public virtual DbSet<tblAddress> tblAddress { get; set; }
        public virtual DbSet<tblAdminCategory> tblAdminCategory { get; set; }
        public virtual DbSet<tblAdminDocument> tblAdminDocument { get; set; }
        public virtual DbSet<tblAdminDocumentLetterType> tblAdminDocumentLetterType { get; set; }
        public virtual DbSet<tblAdminDocumentType> tblAdminDocumentType { get; set; }
        public virtual DbSet<tblAdminLogDate> tblAdminLogDate { get; set; }
        public virtual DbSet<tblAdminUsers> tblAdminUsers { get; set; }
        public virtual DbSet<tblAdminlogin> tblAdminlogin { get; set; }
        public virtual DbSet<tblAgeGroup> tblAgeGroup { get; set; }
        public virtual DbSet<tblAgreement> tblAgreement { get; set; }
        public virtual DbSet<tblAgreementDetail> tblAgreementDetail { get; set; }
        public virtual DbSet<tblAlertLog> tblAlertLog { get; set; }
        public virtual DbSet<tblAlertsAndNotificationDays> tblAlertsAndNotificationDays { get; set; }
        public virtual DbSet<tblAllPages> tblAllPages { get; set; }
        public virtual DbSet<tblAllowAttendanceEmails> tblAllowAttendanceEmails { get; set; }
        public virtual DbSet<tblAllowLeaveType> tblAllowLeaveType { get; set; }
        public virtual DbSet<tblAllowanceStructure> tblAllowanceStructure { get; set; }
        public virtual DbSet<tblAnnouncement> tblAnnouncement { get; set; }
        public virtual DbSet<tblAnnouncementDetailed> tblAnnouncementDetailed { get; set; }
        public virtual DbSet<tblAnnouncementEmail> tblAnnouncementEmail { get; set; }
        public virtual DbSet<tblAnualBalance> tblAnualBalance { get; set; }
        public virtual DbSet<tblApplyOPDESS> tblApplyOPDESS { get; set; }
        public virtual DbSet<tblApplyRoster> tblApplyRoster { get; set; }
        public virtual DbSet<tblApplyRosterMaster> tblApplyRosterMaster { get; set; }
        public virtual DbSet<tblApprovalOvertime> tblApprovalOvertime { get; set; }
        public virtual DbSet<tblAssDesignation> tblAssDesignation { get; set; }
        public virtual DbSet<tblAssignmentNew> tblAssignmentNew { get; set; }
        public virtual DbSet<tblAtsUserClients> tblAtsUserClients { get; set; }
        public virtual DbSet<tblAttendanceAdjustment> tblAttendanceAdjustment { get; set; }
        public virtual DbSet<tblAttendanceAllowance> tblAttendanceAllowance { get; set; }
        public virtual DbSet<tblAttendanceAllowanceDetail> tblAttendanceAllowanceDetail { get; set; }
        public virtual DbSet<tblAttendanceEmailLog> tblAttendanceEmailLog { get; set; }
        public virtual DbSet<tblAttendanceInOut> tblAttendanceInOut { get; set; }
        public virtual DbSet<tblAttendanceLeaveSummary_Report> tblAttendanceLeaveSummary_Report { get; set; }
        public virtual DbSet<tblAttendanceLog> tblAttendanceLog { get; set; }
        public virtual DbSet<tblAttendanceLogTemp> tblAttendanceLogTemp { get; set; }
        public virtual DbSet<tblAttendanceMissingTemplate> tblAttendanceMissingTemplate { get; set; }
        public virtual DbSet<tblAttendanceWatcher> tblAttendanceWatcher { get; set; }
        public virtual DbSet<tblAuditLogEmailCheck> tblAuditLogEmailCheck { get; set; }
        public virtual DbSet<tblBank> tblBank { get; set; }
        public virtual DbSet<tblBankLetterFooter> tblBankLetterFooter { get; set; }
        public virtual DbSet<tblBankLetterHeader> tblBankLetterHeader { get; set; }
        public virtual DbSet<tblBehaviourChart> tblBehaviourChart { get; set; }
        public virtual DbSet<tblBenefit> tblBenefit { get; set; }
        public virtual DbSet<tblBenefitAmount> tblBenefitAmount { get; set; }
        public virtual DbSet<tblBenefitDetail> tblBenefitDetail { get; set; }
        public virtual DbSet<tblBenefitMaster> tblBenefitMaster { get; set; }
        public virtual DbSet<tblBillingReimbursement> tblBillingReimbursement { get; set; }
        public virtual DbSet<tblBillingRemType> tblBillingRemType { get; set; }
        public virtual DbSet<tblBin> tblBin { get; set; }
        public virtual DbSet<tblBlog> tblBlog { get; set; }
        public virtual DbSet<tblBloodRelation> tblBloodRelation { get; set; }
        public virtual DbSet<tblBookPlacement> tblBookPlacement { get; set; }
        public virtual DbSet<tblBooks> tblBooks { get; set; }
        public virtual DbSet<tblBranch> tblBranch { get; set; }
        public virtual DbSet<tblBroadArea> tblBroadArea { get; set; }
        public virtual DbSet<tblBroadAreaDetail> tblBroadAreaDetail { get; set; }
        public virtual DbSet<tblBroadAreaMaster> tblBroadAreaMaster { get; set; }
        public virtual DbSet<tblBusManagement> tblBusManagement { get; set; }
        public virtual DbSet<tblCPR> tblCPR { get; set; }
        public virtual DbSet<tblCallMgmt> tblCallMgmt { get; set; }
        public virtual DbSet<tblCandidateCertification> tblCandidateCertification { get; set; }
        public virtual DbSet<tblCandidateEmailLog> tblCandidateEmailLog { get; set; }
        public virtual DbSet<tblCandidateExperience> tblCandidateExperience { get; set; }
        public virtual DbSet<tblCandidateLog> tblCandidateLog { get; set; }
        public virtual DbSet<tblCandidatePost> tblCandidatePost { get; set; }
        public virtual DbSet<tblCandidateQualification> tblCandidateQualification { get; set; }
        public virtual DbSet<tblCandidateQuestionnaire> tblCandidateQuestionnaire { get; set; }
        public virtual DbSet<tblCandidateStatus> tblCandidateStatus { get; set; }
        public virtual DbSet<tblCareerPathDetail> tblCareerPathDetail { get; set; }
        public virtual DbSet<tblCareerPathMaster> tblCareerPathMaster { get; set; }
        public virtual DbSet<tblCatagoryNew> tblCatagoryNew { get; set; }
        public virtual DbSet<tblCategory> tblCategory { get; set; }
        public virtual DbSet<tblCategoryManagement> tblCategoryManagement { get; set; }
        public virtual DbSet<tblCauseNotice> tblCauseNotice { get; set; }
        public virtual DbSet<tblCauseNoticeEmployee> tblCauseNoticeEmployee { get; set; }
        public virtual DbSet<tblChangeStatus> tblChangeStatus { get; set; }
        public virtual DbSet<tblCheckListChild> tblCheckListChild { get; set; }
        public virtual DbSet<tblCheckListChildDepartment> tblCheckListChildDepartment { get; set; }
        public virtual DbSet<tblCheckListMaster> tblCheckListMaster { get; set; }
        public virtual DbSet<tblChildDep> tblChildDep { get; set; }
        public virtual DbSet<tblCity> tblCity { get; set; }
        public virtual DbSet<tblClass> tblClass { get; set; }
        public virtual DbSet<tblClient> tblClient { get; set; }
        public virtual DbSet<tblClosing> tblClosing { get; set; }
        public virtual DbSet<tblComments> tblComments { get; set; }
        public virtual DbSet<tblCommission> tblCommission { get; set; }
        public virtual DbSet<tblCommissionESS> tblCommissionESS { get; set; }
        public virtual DbSet<tblCommissionType> tblCommissionType { get; set; }
        public virtual DbSet<tblCompAlertEmail> tblCompAlertEmail { get; set; }
        public virtual DbSet<tblCompAttendanceEmail> tblCompAttendanceEmail { get; set; }
        public virtual DbSet<tblCompAttendanceEmailEmployeeList> tblCompAttendanceEmailEmployeeList { get; set; }
        public virtual DbSet<tblCompany> tblCompany { get; set; }
        public virtual DbSet<tblCompanyLetterHeader> tblCompanyLetterHeader { get; set; }
        public virtual DbSet<tblCompanyModule> tblCompanyModule { get; set; }
        public virtual DbSet<tblCompanyOff> tblCompanyOff { get; set; }
        public virtual DbSet<tblCompanyOffMaster> tblCompanyOffMaster { get; set; }
        public virtual DbSet<tblCompanyRights> tblCompanyRights { get; set; }
        public virtual DbSet<tblCompanyType> tblCompanyType { get; set; }
        public virtual DbSet<tblCompensationAttendance> tblCompensationAttendance { get; set; }
        public virtual DbSet<tblCompensationLeave> tblCompensationLeave { get; set; }
        public virtual DbSet<tblComplainType> tblComplainType { get; set; }
        public virtual DbSet<tblContactDBFormDetail> tblContactDBFormDetail { get; set; }
        public virtual DbSet<tblContactDBFormMaster> tblContactDBFormMaster { get; set; }
        public virtual DbSet<tblContactLedge> tblContactLedge { get; set; }
        public virtual DbSet<tblContactUs> tblContactUs { get; set; }
        public virtual DbSet<tblCountry> tblCountry { get; set; }
        public virtual DbSet<tblCurrency> tblCurrency { get; set; }
        public virtual DbSet<tblCustomAlerts> tblCustomAlerts { get; set; }
        public virtual DbSet<tblCustomers> tblCustomers { get; set; }
        public virtual DbSet<tblDailyAttendanceAdjustment> tblDailyAttendanceAdjustment { get; set; }
        public virtual DbSet<tblDailyManualAllowance> tblDailyManualAllowance { get; set; }
        public virtual DbSet<tblDailyManualAttendance> tblDailyManualAttendance { get; set; }
        public virtual DbSet<tblDailyManualOT> tblDailyManualOT { get; set; }
        public virtual DbSet<tblDashboardSettings> tblDashboardSettings { get; set; }
        public virtual DbSet<tblDateOff> tblDateOff { get; set; }
        public virtual DbSet<tblDateOffMaster> tblDateOffMaster { get; set; }
        public virtual DbSet<tblDaysIndicatorDetail> tblDaysIndicatorDetail { get; set; }
        public virtual DbSet<tblDaysIndicatorMaster> tblDaysIndicatorMaster { get; set; }
        public virtual DbSet<tblDeduction> tblDeduction { get; set; }
        public virtual DbSet<tblDeductionStructure> tblDeductionStructure { get; set; }
        public virtual DbSet<tblDeductionType> tblDeductionType { get; set; }
        public virtual DbSet<tblDegree> tblDegree { get; set; }
        public virtual DbSet<tblDegreeATS> tblDegreeATS { get; set; }
        public virtual DbSet<tblDemand> tblDemand { get; set; }
        public virtual DbSet<tblDemandApprovalFlowSave> tblDemandApprovalFlowSave { get; set; }
        public virtual DbSet<tblDemandApprovalFlowSetUp> tblDemandApprovalFlowSetUp { get; set; }
        public virtual DbSet<tblDemandItemDetail> tblDemandItemDetail { get; set; }
        public virtual DbSet<tblDemandItemMaster> tblDemandItemMaster { get; set; }
        public virtual DbSet<tblDemotion> tblDemotion { get; set; }
        public virtual DbSet<tblDep> tblDep { get; set; }
        public virtual DbSet<tblDepDocuments> tblDepDocuments { get; set; }
        public virtual DbSet<tblDepartment> tblDepartment { get; set; }
        public virtual DbSet<tblDepartmentResignEmployee> tblDepartmentResignEmployee { get; set; }
        public virtual DbSet<tblDesig> tblDesig { get; set; }
        public virtual DbSet<tblDesignation> tblDesignation { get; set; }
        public virtual DbSet<tblDetailManualSOP> tblDetailManualSOP { get; set; }
        public virtual DbSet<tblDeviceConfig> tblDeviceConfig { get; set; }
        public virtual DbSet<tblDeviceTemplate> tblDeviceTemplate { get; set; }
        public virtual DbSet<tblDocumentTemplate> tblDocumentTemplate { get; set; }
        public virtual DbSet<tblDocumentTypeSetup> tblDocumentTypeSetup { get; set; }
        public virtual DbSet<tblDonorContact> tblDonorContact { get; set; }
        public virtual DbSet<tblDriver> tblDriver { get; set; }
        public virtual DbSet<tblDriverBus> tblDriverBus { get; set; }
        public virtual DbSet<tblDriverBusHistory> tblDriverBusHistory { get; set; }
        public virtual DbSet<tblDriverManagement> tblDriverManagement { get; set; }
        public virtual DbSet<tblEOBIFund> tblEOBIFund { get; set; }
        public virtual DbSet<tblESSEmailContent> tblESSEmailContent { get; set; }
        public virtual DbSet<tblEarlyOutAuthorization> tblEarlyOutAuthorization { get; set; }
        public virtual DbSet<tblEarlyOutRules> tblEarlyOutRules { get; set; }
        public virtual DbSet<tblEarlyOutRulesNew> tblEarlyOutRulesNew { get; set; }
        public virtual DbSet<tblEarlyOutRulesNewProcess> tblEarlyOutRulesNewProcess { get; set; }
        public virtual DbSet<tblEmail> tblEmail { get; set; }
        public virtual DbSet<tblEmailControl> tblEmailControl { get; set; }
        public virtual DbSet<tblEmailFooter> tblEmailFooter { get; set; }
        public virtual DbSet<tblEmailRecord> tblEmailRecord { get; set; }
        public virtual DbSet<tblEmailReminder> tblEmailReminder { get; set; }
        public virtual DbSet<tblEmailSetting> tblEmailSetting { get; set; }
        public virtual DbSet<tblEmailStatus> tblEmailStatus { get; set; }
        public virtual DbSet<tblEmailTemplates> tblEmailTemplates { get; set; }
        public virtual DbSet<tblEmpAttendanceLive> tblEmpAttendanceLive { get; set; }
        public virtual DbSet<tblEmpContacts> tblEmpContacts { get; set; }
        public virtual DbSet<tblEmpDePromotion> tblEmpDePromotion { get; set; }
        public virtual DbSet<tblEmpDocuments> tblEmpDocuments { get; set; }
        public virtual DbSet<tblEmpExit> tblEmpExit { get; set; }
        public virtual DbSet<tblEmpExperience> tblEmpExperience { get; set; }
        public virtual DbSet<tblEmpFamilyInfo> tblEmpFamilyInfo { get; set; }
        public virtual DbSet<tblEmpFeedback> tblEmpFeedback { get; set; }
        public virtual DbSet<tblEmpHealthInsurrance> tblEmpHealthInsurrance { get; set; }
        public virtual DbSet<tblEmpIncrements> tblEmpIncrements { get; set; }
        public virtual DbSet<tblEmpJobDesc> tblEmpJobDesc { get; set; }
        public virtual DbSet<tblEmpLeavesHistory> tblEmpLeavesHistory { get; set; }
        public virtual DbSet<tblEmpMedicalTaxHistroy> tblEmpMedicalTaxHistroy { get; set; }
        public virtual DbSet<tblEmpPromotion> tblEmpPromotion { get; set; }
        public virtual DbSet<tblEmpReferences> tblEmpReferences { get; set; }
        public virtual DbSet<tblEmpStatus> tblEmpStatus { get; set; }
        public virtual DbSet<tblEmployeeAssignGoal> tblEmployeeAssignGoal { get; set; }
        public virtual DbSet<tblEmployeeAssignGoalDetail> tblEmployeeAssignGoalDetail { get; set; }
        public virtual DbSet<tblEmployeeAssignGoalDetailSendRequest> tblEmployeeAssignGoalDetailSendRequest { get; set; }
        public virtual DbSet<tblEmployeeAssignGoalMsterNew> tblEmployeeAssignGoalMsterNew { get; set; }
        public virtual DbSet<tblEmployeeAssociation> tblEmployeeAssociation { get; set; }
        public virtual DbSet<tblEmployeeAttendance> tblEmployeeAttendance { get; set; }
        public virtual DbSet<tblEmployeeBackgroundCheck> tblEmployeeBackgroundCheck { get; set; }
        public virtual DbSet<tblEmployeeCheckListApproved> tblEmployeeCheckListApproved { get; set; }
        public virtual DbSet<tblEmployeeChild> tblEmployeeChild { get; set; }
        public virtual DbSet<tblEmployeeClearanceCheckListApproved> tblEmployeeClearanceCheckListApproved { get; set; }
        public virtual DbSet<tblEmployeeComplains> tblEmployeeComplains { get; set; }
        public virtual DbSet<tblEmployeeComplaints> tblEmployeeComplaints { get; set; }
        public virtual DbSet<tblEmployeeFields> tblEmployeeFields { get; set; }
        public virtual DbSet<tblEmployeeFieldsDtl> tblEmployeeFieldsDtl { get; set; }
        public virtual DbSet<tblEmployeeFine> tblEmployeeFine { get; set; }
        public virtual DbSet<tblEmployeeItemAssign> tblEmployeeItemAssign { get; set; }
        public virtual DbSet<tblEmployeeJobPost> tblEmployeeJobPost { get; set; }
        public virtual DbSet<tblEmployeeJobRequest> tblEmployeeJobRequest { get; set; }
        public virtual DbSet<tblEmployeeLeaveQouta> tblEmployeeLeaveQouta { get; set; }
        public virtual DbSet<tblEmployeeLoanDetail> tblEmployeeLoanDetail { get; set; }
        public virtual DbSet<tblEmployeeLoanDetailMerge> tblEmployeeLoanDetailMerge { get; set; }
        public virtual DbSet<tblEmployeeLoanMaster> tblEmployeeLoanMaster { get; set; }
        public virtual DbSet<tblEmployeeMgmt> tblEmployeeMgmt { get; set; }
        public virtual DbSet<tblEmployeeOnBoard> tblEmployeeOnBoard { get; set; }
        public virtual DbSet<tblEmployeeOnBoarding> tblEmployeeOnBoarding { get; set; }
        public virtual DbSet<tblEmployeeOnBoardingBasicDetails> tblEmployeeOnBoardingBasicDetails { get; set; }
        public virtual DbSet<tblEmployeeOnBoardingContactDetails> tblEmployeeOnBoardingContactDetails { get; set; }
        public virtual DbSet<tblEmployeeOnBoardingDependantsDetails> tblEmployeeOnBoardingDependantsDetails { get; set; }
        public virtual DbSet<tblEmployeeOnBoardingExperienceDetails> tblEmployeeOnBoardingExperienceDetails { get; set; }
        public virtual DbSet<tblEmployeeOnBoardingQualificationDetails> tblEmployeeOnBoardingQualificationDetails { get; set; }
        public virtual DbSet<tblEmployeeOnBoardingReasons> tblEmployeeOnBoardingReasons { get; set; }
        public virtual DbSet<tblEmployeeOvertimeFlow> tblEmployeeOvertimeFlow { get; set; }
        public virtual DbSet<tblEmployeeResignFlow> tblEmployeeResignFlow { get; set; }
        public virtual DbSet<tblEmployeeSetting> tblEmployeeSetting { get; set; }
        public virtual DbSet<tblEmployeeTransfer> tblEmployeeTransfer { get; set; }
        public virtual DbSet<tblEmployeeType> tblEmployeeType { get; set; }
        public virtual DbSet<tblEmployeerQualification> tblEmployeerQualification { get; set; }
        public virtual DbSet<tblEmployementHistory> tblEmployementHistory { get; set; }
        public virtual DbSet<tblEobiDays> tblEobiDays { get; set; }
        public virtual DbSet<tblEssEmail> tblEssEmail { get; set; }
        public virtual DbSet<tblEssMultipleEmployee> tblEssMultipleEmployee { get; set; }
        public virtual DbSet<tblEssNotification> tblEssNotification { get; set; }
        public virtual DbSet<tblEssloginLogout> tblEssloginLogout { get; set; }
        public virtual DbSet<tblExceptionDetails> tblExceptionDetails { get; set; }
        public virtual DbSet<tblExpenceMgmt> tblExpenceMgmt { get; set; }
        public virtual DbSet<tblExpenceMgmtESS> tblExpenceMgmtESS { get; set; }
        public virtual DbSet<tblExpenceType> tblExpenceType { get; set; }
        public virtual DbSet<tblExpenseDetail> tblExpenseDetail { get; set; }
        public virtual DbSet<tblExpenseFlowEmployee> tblExpenseFlowEmployee { get; set; }
        public virtual DbSet<tblFAQ> tblFAQ { get; set; }
        public virtual DbSet<tblFAQAdvance> tblFAQAdvance { get; set; }
        public virtual DbSet<tblFAQAssets> tblFAQAssets { get; set; }
        public virtual DbSet<tblFAQAttend> tblFAQAttend { get; set; }
        public virtual DbSet<tblFAQESS> tblFAQESS { get; set; }
        public virtual DbSet<tblFAQPayroll> tblFAQPayroll { get; set; }
        public virtual DbSet<tblFAQReport> tblFAQReport { get; set; }
        public virtual DbSet<tblFAQSetup> tblFAQSetup { get; set; }
        public virtual DbSet<tblFeeHeads> tblFeeHeads { get; set; }
        public virtual DbSet<tblFieldsSetting> tblFieldsSetting { get; set; }
        public virtual DbSet<tblFileImage> tblFileImage { get; set; }
        public virtual DbSet<tblFinalSettlement> tblFinalSettlement { get; set; }
        public virtual DbSet<tblFineType> tblFineType { get; set; }
        public virtual DbSet<tblFloaterLeave> tblFloaterLeave { get; set; }
        public virtual DbSet<tblFloaterLeaveEmail> tblFloaterLeaveEmail { get; set; }
        public virtual DbSet<tblFuel> tblFuel { get; set; }
        public virtual DbSet<tblGeneralContacts> tblGeneralContacts { get; set; }
        public virtual DbSet<tblGoalsObjectiveDetail> tblGoalsObjectiveDetail { get; set; }
        public virtual DbSet<tblGoalsObjectivemaster> tblGoalsObjectivemaster { get; set; }
        public virtual DbSet<tblGrades> tblGrades { get; set; }
        public virtual DbSet<tblGroupControl> tblGroupControl { get; set; }
        public virtual DbSet<tblHREmailSetting> tblHREmailSetting { get; set; }
        public virtual DbSet<tblHelpDeskDetail> tblHelpDeskDetail { get; set; }
        public virtual DbSet<tblHelpDeskMaster> tblHelpDeskMaster { get; set; }
        public virtual DbSet<tblHelpDeskType> tblHelpDeskType { get; set; }
        public virtual DbSet<tblHostelLocation> tblHostelLocation { get; set; }
        public virtual DbSet<tblIPS> tblIPS { get; set; }
        public virtual DbSet<tblIncentive> tblIncentive { get; set; }
        public virtual DbSet<tblIncentiveTaxMgmt> tblIncentiveTaxMgmt { get; set; }
        public virtual DbSet<tblIncentiveType> tblIncentiveType { get; set; }
        public virtual DbSet<tblIncomingCalls> tblIncomingCalls { get; set; }
        public virtual DbSet<tblIncrement> tblIncrement { get; set; }
        public virtual DbSet<tblIncrementStatus> tblIncrementStatus { get; set; }
        public virtual DbSet<tblInstallmentDetail> tblInstallmentDetail { get; set; }
        public virtual DbSet<tblInstallmentMaster> tblInstallmentMaster { get; set; }
        public virtual DbSet<tblInternetBillReimbursement> tblInternetBillReimbursement { get; set; }
        public virtual DbSet<tblInternetBillRemType> tblInternetBillRemType { get; set; }
        public virtual DbSet<tblInventory> tblInventory { get; set; }
        public virtual DbSet<tblIssueBookDetail> tblIssueBookDetail { get; set; }
        public virtual DbSet<tblIssueBookMaster> tblIssueBookMaster { get; set; }
        public virtual DbSet<tblIssueDetail> tblIssueDetail { get; set; }
        public virtual DbSet<tblIssueMaster> tblIssueMaster { get; set; }
        public virtual DbSet<tblItem> tblItem { get; set; }
        public virtual DbSet<tblItemCatgory> tblItemCatgory { get; set; }
        public virtual DbSet<tblItemIssueDetail> tblItemIssueDetail { get; set; }
        public virtual DbSet<tblItemIssueMaster> tblItemIssueMaster { get; set; }
        public virtual DbSet<tblItemRate> tblItemRate { get; set; }
        public virtual DbSet<tblItemRateCustom> tblItemRateCustom { get; set; }
        public virtual DbSet<tblItems> tblItems { get; set; }
        public virtual DbSet<tblJobDescription> tblJobDescription { get; set; }
        public virtual DbSet<tblJobNumber> tblJobNumber { get; set; }
        public virtual DbSet<tblJobPostEmails> tblJobPostEmails { get; set; }
        public virtual DbSet<tblJobPostNotify> tblJobPostNotify { get; set; }
        public virtual DbSet<tblJobRequest> tblJobRequest { get; set; }
        public virtual DbSet<tblJobRequestDetail> tblJobRequestDetail { get; set; }
        public virtual DbSet<tblLanguage> tblLanguage { get; set; }
        public virtual DbSet<tblLateAllowance> tblLateAllowance { get; set; }
        public virtual DbSet<tblLateAllowanceDetail> tblLateAllowanceDetail { get; set; }
        public virtual DbSet<tblLateAttendanceExemption> tblLateAttendanceExemption { get; set; }
        public virtual DbSet<tblLateEmailControl> tblLateEmailControl { get; set; }
        public virtual DbSet<tblLateInAuthorization> tblLateInAuthorization { get; set; }
        public virtual DbSet<tblLateInRules> tblLateInRules { get; set; }
        public virtual DbSet<tblLateInRulesNew> tblLateInRulesNew { get; set; }
        public virtual DbSet<tblLateInRulesNewProcess> tblLateInRulesNewProcess { get; set; }
        public virtual DbSet<tblLateInRulesProcess> tblLateInRulesProcess { get; set; }
        public virtual DbSet<tblLateInSlabs> tblLateInSlabs { get; set; }
        public virtual DbSet<tblLeaveApprovalFlowSave> tblLeaveApprovalFlowSave { get; set; }
        public virtual DbSet<tblLeaveApprovalFlowSetUp> tblLeaveApprovalFlowSetUp { get; set; }
        public virtual DbSet<tblLeaveCount> tblLeaveCount { get; set; }
        public virtual DbSet<tblLeaveEmailCCSetting> tblLeaveEmailCCSetting { get; set; }
        public virtual DbSet<tblLeaveEncashment> tblLeaveEncashment { get; set; }
        public virtual DbSet<tblLeaveTamplateNew> tblLeaveTamplateNew { get; set; }
        public virtual DbSet<tblLeaveTemplateDetail> tblLeaveTemplateDetail { get; set; }
        public virtual DbSet<tblLeaveTemplateMaster> tblLeaveTemplateMaster { get; set; }
        public virtual DbSet<tblLeaveType> tblLeaveType { get; set; }
        public virtual DbSet<tblLeaves> tblLeaves { get; set; }
        public virtual DbSet<tblLeavesPeriod> tblLeavesPeriod { get; set; }
        public virtual DbSet<tblLetterOfThanksTemplate> tblLetterOfThanksTemplate { get; set; }
        public virtual DbSet<tblLoan> tblLoan { get; set; }
        public virtual DbSet<tblLoanAjustDetail> tblLoanAjustDetail { get; set; }
        public virtual DbSet<tblLoanModuleFlowSetUp> tblLoanModuleFlowSetUp { get; set; }
        public virtual DbSet<tblLoanModuleFlowSetUpEmployee> tblLoanModuleFlowSetUpEmployee { get; set; }
        public virtual DbSet<tblLoanPurpose> tblLoanPurpose { get; set; }
        public virtual DbSet<tblLoanRequest> tblLoanRequest { get; set; }
        public virtual DbSet<tblLoanRequestDetail> tblLoanRequestDetail { get; set; }
        public virtual DbSet<tblLocation> tblLocation { get; set; }
        public virtual DbSet<tblLocationMaster> tblLocationMaster { get; set; }
        public virtual DbSet<tblLocationWareHouse> tblLocationWareHouse { get; set; }
        public virtual DbSet<tblLog> tblLog { get; set; }
        public virtual DbSet<tblLogDate> tblLogDate { get; set; }
        public virtual DbSet<tblLoginHistory> tblLoginHistory { get; set; }
        public virtual DbSet<tblLubricants> tblLubricants { get; set; }
        public virtual DbSet<tblMainContactPerson> tblMainContactPerson { get; set; }
        public virtual DbSet<tblMaintance> tblMaintance { get; set; }
        public virtual DbSet<tblManagerAuthorised> tblManagerAuthorised { get; set; }
        public virtual DbSet<tblManualAtendanceRights> tblManualAtendanceRights { get; set; }
        public virtual DbSet<tblManualAttReason> tblManualAttReason { get; set; }
        public virtual DbSet<tblManualAttendanceEss> tblManualAttendanceEss { get; set; }
        public virtual DbSet<tblManualSOPUpload> tblManualSOPUpload { get; set; }
        public virtual DbSet<tblManualnSOP> tblManualnSOP { get; set; }
        public virtual DbSet<tblMedicalAllowance> tblMedicalAllowance { get; set; }
        public virtual DbSet<tblMedicalOpening> tblMedicalOpening { get; set; }
        public virtual DbSet<tblMedicalPeriod> tblMedicalPeriod { get; set; }
        public virtual DbSet<tblMenualBreak> tblMenualBreak { get; set; }
        public virtual DbSet<tblModuleRights> tblModuleRights { get; set; }
        public virtual DbSet<tblModules> tblModules { get; set; }
        public virtual DbSet<tblMonths> tblMonths { get; set; }
        public virtual DbSet<tblMyMail> tblMyMail { get; set; }
        public virtual DbSet<tblNationality> tblNationality { get; set; }
        public virtual DbSet<tblNews> tblNews { get; set; }
        public virtual DbSet<tblNewsletter> tblNewsletter { get; set; }
        public virtual DbSet<tblNotice> tblNotice { get; set; }
        public virtual DbSet<tblNumbers> tblNumbers { get; set; }
        public virtual DbSet<tblOPDEmployee> tblOPDEmployee { get; set; }
        public virtual DbSet<tblOPDGrade> tblOPDGrade { get; set; }
        public virtual DbSet<tblOPDHealthPeriod> tblOPDHealthPeriod { get; set; }
        public virtual DbSet<tblOPDOpening> tblOPDOpening { get; set; }
        public virtual DbSet<tblOPDWithDraw> tblOPDWithDraw { get; set; }
        public virtual DbSet<tblOTPGenerator> tblOTPGenerator { get; set; }
        public virtual DbSet<tblOffBoarding> tblOffBoarding { get; set; }
        public virtual DbSet<tblOnBoarding> tblOnBoarding { get; set; }
        public virtual DbSet<tblOpeningBalance> tblOpeningBalance { get; set; }
        public virtual DbSet<tblOpeningEOBI> tblOpeningEOBI { get; set; }
        public virtual DbSet<tblOpeningSocailSecurity> tblOpeningSocailSecurity { get; set; }
        public virtual DbSet<tblOpeningTax> tblOpeningTax { get; set; }
        public virtual DbSet<tblOrderMgmt> tblOrderMgmt { get; set; }
        public virtual DbSet<tblOverTime> tblOverTime { get; set; }
        public virtual DbSet<tblOverTimeApprove> tblOverTimeApprove { get; set; }
        public virtual DbSet<tblOverTimeDetail> tblOverTimeDetail { get; set; }
        public virtual DbSet<tblOverTimeManual> tblOverTimeManual { get; set; }
        public virtual DbSet<tblOverTimeMaster> tblOverTimeMaster { get; set; }
        public virtual DbSet<tblOverTimeRequestDetail> tblOverTimeRequestDetail { get; set; }
        public virtual DbSet<tblOverTimeRequestMaster> tblOverTimeRequestMaster { get; set; }
        public virtual DbSet<tblOvertimeApprovalDetail> tblOvertimeApprovalDetail { get; set; }
        public virtual DbSet<tblOvertimeSlabs> tblOvertimeSlabs { get; set; }
        public virtual DbSet<tblPMSAdjustment> tblPMSAdjustment { get; set; }
        public virtual DbSet<tblPMSAnalysisData> tblPMSAnalysisData { get; set; }
        public virtual DbSet<tblPMSApprovalFlowSave> tblPMSApprovalFlowSave { get; set; }
        public virtual DbSet<tblPMSApprovalFlowSetUp> tblPMSApprovalFlowSetUp { get; set; }
        public virtual DbSet<tblPMSDateWiseIncrement> tblPMSDateWiseIncrement { get; set; }
        public virtual DbSet<tblPMSFooterRemark> tblPMSFooterRemark { get; set; }
        public virtual DbSet<tblPMSHistory> tblPMSHistory { get; set; }
        public virtual DbSet<tblPMSIncrementHistory> tblPMSIncrementHistory { get; set; }
        public virtual DbSet<tblPMSIndicatorMergeEss> tblPMSIndicatorMergeEss { get; set; }
        public virtual DbSet<tblPMSMultipleDesignationGradeWise> tblPMSMultipleDesignationGradeWise { get; set; }
        public virtual DbSet<tblPMSPage> tblPMSPage { get; set; }
        public virtual DbSet<tblPMSPageDetail> tblPMSPageDetail { get; set; }
        public virtual DbSet<tblPMSParentIndicator> tblPMSParentIndicator { get; set; }
        public virtual DbSet<tblPMSPeriodWise> tblPMSPeriodWise { get; set; }
        public virtual DbSet<tblPMSScheduler> tblPMSScheduler { get; set; }
        public virtual DbSet<tblPMSTaskCategory> tblPMSTaskCategory { get; set; }
        public virtual DbSet<tblPMSTypeNew> tblPMSTypeNew { get; set; }
        public virtual DbSet<tblPMSWeitage> tblPMSWeitage { get; set; }
        public virtual DbSet<tblPMSWorkConductBase> tblPMSWorkConductBase { get; set; }
        public virtual DbSet<tblPOSRecipe> tblPOSRecipe { get; set; }
        public virtual DbSet<tblPages> tblPages { get; set; }
        public virtual DbSet<tblParentBillingRemType> tblParentBillingRemType { get; set; }
        public virtual DbSet<tblParents> tblParents { get; set; }
        public virtual DbSet<tblPayRoll> tblPayRoll { get; set; }
        public virtual DbSet<tblPayRollDetail> tblPayRollDetail { get; set; }
        public virtual DbSet<tblPayRollGeneralSetting> tblPayRollGeneralSetting { get; set; }
        public virtual DbSet<tblPayRollTemplate> tblPayRollTemplate { get; set; }
        public virtual DbSet<tblPayrollApproval> tblPayrollApproval { get; set; }
        public virtual DbSet<tblPayrollBranchPercentage> tblPayrollBranchPercentage { get; set; }
        public virtual DbSet<tblPayrollDeletionLocation> tblPayrollDeletionLocation { get; set; }
        public virtual DbSet<tblPayrollEmailSend> tblPayrollEmailSend { get; set; }
        public virtual DbSet<tblPayrollStructure> tblPayrollStructure { get; set; }
        public virtual DbSet<tblPayrollVerificationFlow> tblPayrollVerificationFlow { get; set; }
        public virtual DbSet<tblPerformanceAppraisal> tblPerformanceAppraisal { get; set; }
        public virtual DbSet<tblPerformanceAppraisalDetailMonth> tblPerformanceAppraisalDetailMonth { get; set; }
        public virtual DbSet<tblPerformanceAppraisalMailMaster> tblPerformanceAppraisalMailMaster { get; set; }
        public virtual DbSet<tblPerformanceAppraisalSaveData> tblPerformanceAppraisalSaveData { get; set; }
        public virtual DbSet<tblPerformanceApraisalMaster> tblPerformanceApraisalMaster { get; set; }
        public virtual DbSet<tblPerformanceTemplateDetail> tblPerformanceTemplateDetail { get; set; }
        public virtual DbSet<tblPerformancetemplate> tblPerformancetemplate { get; set; }
        public virtual DbSet<tblPlannerTrainingDetail> tblPlannerTrainingDetail { get; set; }
        public virtual DbSet<tblPreQualification> tblPreQualification { get; set; }
        public virtual DbSet<tblPreviousSchoolHistory> tblPreviousSchoolHistory { get; set; }
        public virtual DbSet<tblProductCategory> tblProductCategory { get; set; }
        public virtual DbSet<tblProfit> tblProfit { get; set; }
        public virtual DbSet<tblProjectAssign> tblProjectAssign { get; set; }
        public virtual DbSet<tblProjectDetails> tblProjectDetails { get; set; }
        public virtual DbSet<tblProjectSetup> tblProjectSetup { get; set; }
        public virtual DbSet<tblProjects> tblProjects { get; set; }
        public virtual DbSet<tblPromotion> tblPromotion { get; set; }
        public virtual DbSet<tblProvidentFund> tblProvidentFund { get; set; }
        public virtual DbSet<tblProvidentFund_Adjustment> tblProvidentFund_Adjustment { get; set; }
        public virtual DbSet<tblPurchaseAsset> tblPurchaseAsset { get; set; }
        public virtual DbSet<tblPurchaseOrder> tblPurchaseOrder { get; set; }
        public virtual DbSet<tblQuesCategory> tblQuesCategory { get; set; }
        public virtual DbSet<tblQuestionnaireDetails> tblQuestionnaireDetails { get; set; }
        public virtual DbSet<tblQuestionnaireMaster> tblQuestionnaireMaster { get; set; }
        public virtual DbSet<tblQuotation> tblQuotation { get; set; }
        public virtual DbSet<tblQuotationAdminM> tblQuotationAdminM { get; set; }
        public virtual DbSet<tblRack> tblRack { get; set; }
        public virtual DbSet<tblReceivedRegisterDetail> tblReceivedRegisterDetail { get; set; }
        public virtual DbSet<tblReceptionMgmt> tblReceptionMgmt { get; set; }
        public virtual DbSet<tblRefundEOBI> tblRefundEOBI { get; set; }
        public virtual DbSet<tblRefundPolicy> tblRefundPolicy { get; set; }
        public virtual DbSet<tblReibursmentReportLock> tblReibursmentReportLock { get; set; }
        public virtual DbSet<tblReligion> tblReligion { get; set; }
        public virtual DbSet<tblReportHeadFooter> tblReportHeadFooter { get; set; }
        public virtual DbSet<tblReqTypeDepartment> tblReqTypeDepartment { get; set; }
        public virtual DbSet<tblRequestManagement> tblRequestManagement { get; set; }
        public virtual DbSet<tblRequestNotes> tblRequestNotes { get; set; }
        public virtual DbSet<tblRequestStatusLog> tblRequestStatusLog { get; set; }
        public virtual DbSet<tblRequestType> tblRequestType { get; set; }
        public virtual DbSet<tblRequestTypeDetail> tblRequestTypeDetail { get; set; }
        public virtual DbSet<tblReservedBookDetail> tblReservedBookDetail { get; set; }
        public virtual DbSet<tblReservedBookMaster> tblReservedBookMaster { get; set; }
        public virtual DbSet<tblResignDetail> tblResignDetail { get; set; }
        public virtual DbSet<tblResignEmployee> tblResignEmployee { get; set; }
        public virtual DbSet<tblReviewProfile> tblReviewProfile { get; set; }
        public virtual DbSet<tblRooms> tblRooms { get; set; }
        public virtual DbSet<tblRoster> tblRoster { get; set; }
        public virtual DbSet<tblRoutDetail> tblRoutDetail { get; set; }
        public virtual DbSet<tblRoutMaster> tblRoutMaster { get; set; }
        public virtual DbSet<tblSMSDetails> tblSMSDetails { get; set; }
        public virtual DbSet<tblSalary> tblSalary { get; set; }
        public virtual DbSet<tblSalaryAdvance> tblSalaryAdvance { get; set; }
        public virtual DbSet<tblSaveNotificationEmailRecord> tblSaveNotificationEmailRecord { get; set; }
        public virtual DbSet<tblScheduleOfWorks> tblScheduleOfWorks { get; set; }
        public virtual DbSet<tblSection> tblSection { get; set; }
        public virtual DbSet<tblSecurityRefundable> tblSecurityRefundable { get; set; }
        public virtual DbSet<tblSendAbsentEmailRecords> tblSendAbsentEmailRecords { get; set; }
        public virtual DbSet<tblSendAnalysisWeeklyEmailRecords> tblSendAnalysisWeeklyEmailRecords { get; set; }
        public virtual DbSet<tblSendDailyAttEmailRecords> tblSendDailyAttEmailRecords { get; set; }
        public virtual DbSet<tblSendLateEmailRecords> tblSendLateEmailRecords { get; set; }
        public virtual DbSet<tblSendMsgToEmployee> tblSendMsgToEmployee { get; set; }
        public virtual DbSet<tblSession> tblSession { get; set; }
        public virtual DbSet<tblSetting> tblSetting { get; set; }
        public virtual DbSet<tblSettingLiveModule> tblSettingLiveModule { get; set; }
        public virtual DbSet<tblSettingOT> tblSettingOT { get; set; }
        public virtual DbSet<tblShelves> tblShelves { get; set; }
        public virtual DbSet<tblShiftChild> tblShiftChild { get; set; }
        public virtual DbSet<tblShiftDetail> tblShiftDetail { get; set; }
        public virtual DbSet<tblShiftDifference> tblShiftDifference { get; set; }
        public virtual DbSet<tblShiftEmployee> tblShiftEmployee { get; set; }
        public virtual DbSet<tblShiftLog> tblShiftLog { get; set; }
        public virtual DbSet<tblShiftMaster> tblShiftMaster { get; set; }
        public virtual DbSet<tblShiftPlaning> tblShiftPlaning { get; set; }
        public virtual DbSet<tblShortMinSlabs> tblShortMinSlabs { get; set; }
        public virtual DbSet<tblSignature> tblSignature { get; set; }
        public virtual DbSet<tblSlotsManagement> tblSlotsManagement { get; set; }
        public virtual DbSet<tblSocialSecurity> tblSocialSecurity { get; set; }
        public virtual DbSet<tblSocialSecurityDays> tblSocialSecurityDays { get; set; }
        public virtual DbSet<tblSparePart> tblSparePart { get; set; }
        public virtual DbSet<tblSpouseInfo> tblSpouseInfo { get; set; }
        public virtual DbSet<tblState> tblState { get; set; }
        public virtual DbSet<tblStockDetail> tblStockDetail { get; set; }
        public virtual DbSet<tblStoreRestdaysOverTime> tblStoreRestdaysOverTime { get; set; }
        public virtual DbSet<tblStrengthEmployee> tblStrengthEmployee { get; set; }
        public virtual DbSet<tblStrengthandAreasImprovement> tblStrengthandAreasImprovement { get; set; }
        public virtual DbSet<tblStudent> tblStudent { get; set; }
        public virtual DbSet<tblStudentAttendance> tblStudentAttendance { get; set; }
        public virtual DbSet<tblStudentClassSection> tblStudentClassSection { get; set; }
        public virtual DbSet<tblStudentHealthHabit> tblStudentHealthHabit { get; set; }
        public virtual DbSet<tblStudentteacherBusStop> tblStudentteacherBusStop { get; set; }
        public virtual DbSet<tblSubDep> tblSubDep { get; set; }
        public virtual DbSet<tblSubcompany> tblSubcompany { get; set; }
        public virtual DbSet<tblSubject> tblSubject { get; set; }
        public virtual DbSet<tblSupplier> tblSupplier { get; set; }
        public virtual DbSet<tblSwapRosterShiftLog> tblSwapRosterShiftLog { get; set; }
        public virtual DbSet<tblTaskCat> tblTaskCat { get; set; }
        public virtual DbSet<tblTaskChat> tblTaskChat { get; set; }
        public virtual DbSet<tblTaskClient> tblTaskClient { get; set; }
        public virtual DbSet<tblTaskClientDetailEmp> tblTaskClientDetailEmp { get; set; }
        public virtual DbSet<tblTaskComments> tblTaskComments { get; set; }
        public virtual DbSet<tblTaskDateTimeDetail> tblTaskDateTimeDetail { get; set; }
        public virtual DbSet<tblTaskDetails> tblTaskDetails { get; set; }
        public virtual DbSet<tblTaskEmailCheck> tblTaskEmailCheck { get; set; }
        public virtual DbSet<tblTaskEmp> tblTaskEmp { get; set; }
        public virtual DbSet<tblTaskLabel> tblTaskLabel { get; set; }
        public virtual DbSet<tblTaskMeasurementKPI> tblTaskMeasurementKPI { get; set; }
        public virtual DbSet<tblTaskMgmt> tblTaskMgmt { get; set; }
        public virtual DbSet<tblTaskMgmtMaster> tblTaskMgmtMaster { get; set; }
        public virtual DbSet<tblTaskMgmtSetting> tblTaskMgmtSetting { get; set; }
        public virtual DbSet<tblTaskModeration> tblTaskModeration { get; set; }
        public virtual DbSet<tblTaskProgressDetail> tblTaskProgressDetail { get; set; }
        public virtual DbSet<tblTaskProgressMaster> tblTaskProgressMaster { get; set; }
        public virtual DbSet<tblTaskProject> tblTaskProject { get; set; }
        public virtual DbSet<tblTaskProjectDetail> tblTaskProjectDetail { get; set; }
        public virtual DbSet<tblTaskRating> tblTaskRating { get; set; }
        public virtual DbSet<tblTaxAdj> tblTaxAdj { get; set; }
        public virtual DbSet<tblTaxCertificationDetail> tblTaxCertificationDetail { get; set; }
        public virtual DbSet<tblTaxDetail> tblTaxDetail { get; set; }
        public virtual DbSet<tblTaxMaster> tblTaxMaster { get; set; }
        public virtual DbSet<tblTeacherMgmt> tblTeacherMgmt { get; set; }
        public virtual DbSet<tblTeacherReferences> tblTeacherReferences { get; set; }
        public virtual DbSet<tblTeacherSubject> tblTeacherSubject { get; set; }
        public virtual DbSet<tblTeamAttendanceRules> tblTeamAttendanceRules { get; set; }
        public virtual DbSet<tblTexPeriod> tblTexPeriod { get; set; }
        public virtual DbSet<tblTexSlabs> tblTexSlabs { get; set; }
        public virtual DbSet<tblTicketDetails> tblTicketDetails { get; set; }
        public virtual DbSet<tblTicketMaster> tblTicketMaster { get; set; }
        public virtual DbSet<tblTimeSheetDetail> tblTimeSheetDetail { get; set; }
        public virtual DbSet<tblTimeSheetMaster> tblTimeSheetMaster { get; set; }
        public virtual DbSet<tblTimeTable> tblTimeTable { get; set; }
        public virtual DbSet<tblTitleHelpDesk> tblTitleHelpDesk { get; set; }
        public virtual DbSet<tblTrainingApprovalFlowSave> tblTrainingApprovalFlowSave { get; set; }
        public virtual DbSet<tblTrainingFlowSetUp> tblTrainingFlowSetUp { get; set; }
        public virtual DbSet<tblTransferOrder> tblTransferOrder { get; set; }
        public virtual DbSet<tblTravel> tblTravel { get; set; }
        public virtual DbSet<tblTravelESS> tblTravelESS { get; set; }
        public virtual DbSet<tblTravelExpenseDetail> tblTravelExpenseDetail { get; set; }
        public virtual DbSet<tblTravelExpenseMaster> tblTravelExpenseMaster { get; set; }
        public virtual DbSet<tblUnit> tblUnit { get; set; }
        public virtual DbSet<tblUnitManagement> tblUnitManagement { get; set; }
        public virtual DbSet<tblUniversities> tblUniversities { get; set; }
        public virtual DbSet<tblUserBranches> tblUserBranches { get; set; }
        public virtual DbSet<tblUserRights> tblUserRights { get; set; }
        public virtual DbSet<tblUserRole> tblUserRole { get; set; }
        public virtual DbSet<tblUserRoleRights> tblUserRoleRights { get; set; }
        public virtual DbSet<tblUserType> tblUserType { get; set; }
        public virtual DbSet<tblUsers> tblUsers { get; set; }
        public virtual DbSet<tblVehicalType> tblVehicalType { get; set; }
        public virtual DbSet<tblVehicleManagement> tblVehicleManagement { get; set; }
        public virtual DbSet<tblVehicleSetup> tblVehicleSetup { get; set; }
        public virtual DbSet<tblVendorProduct> tblVendorProduct { get; set; }
        public virtual DbSet<tblVendorProducts> tblVendorProducts { get; set; }
        public virtual DbSet<tblVendorProductsDetail> tblVendorProductsDetail { get; set; }
        public virtual DbSet<tblVersion> tblVersion { get; set; }
        public virtual DbSet<tblWarehouseManagement> tblWarehouseManagement { get; set; }
        public virtual DbSet<tblWebAdminSettings> tblWebAdminSettings { get; set; }
        public virtual DbSet<tblWishes> tblWishes { get; set; }
        public virtual DbSet<tblWorkingDays> tblWorkingDays { get; set; }
        public virtual DbSet<tblWorkingDaysSlabs> tblWorkingDaysSlabs { get; set; }
        public virtual DbSet<tblbloodgroup> tblbloodgroup { get; set; }
        public virtual DbSet<tbldashboardComment> tbldashboardComment { get; set; }
        public virtual DbSet<tblprovidentfunds> tblprovidentfunds { get; set; }
        public virtual DbSet<tblpublicHolidayMaster> tblpublicHolidayMaster { get; set; }
        public virtual DbSet<tblpublicholidaychild> tblpublicholidaychild { get; set; }
        public virtual DbSet<tblstockMaster> tblstockMaster { get; set; }
        public virtual DbSet<tbltagbranch> tbltagbranch { get; set; }
        public virtual DbSet<tbltopoffendsvalue> tbltopoffendsvalue { get; set; }
        public virtual DbSet<viewStock> viewStock { get; set; }
        public virtual DbSet<vwEmployee> vwEmployee { get; set; }
        public virtual DbSet<vwGetEmployees> vwGetEmployees { get; set; }
        public virtual DbSet<vwGetLeavesDetail> vwGetLeavesDetail { get; set; }
        public virtual DbSet<wvEmployeeNewView> wvEmployeeNewView { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=169.61.243.116;database=HRMS_company_New;Trusted_Connection=True;User Id=bil;Password=112;Integrated Security = false;;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FAQLeave>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<HRMS_company_New>(entity =>
            {
                entity.HasKey(e => e.intSeqID)
                    .HasName("PK_tblEobiDays");
            });

            modelBuilder.Entity<Query_>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<RequestTrainingForm>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblATSClients>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblATSFlowEmployee>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblATSFormControl>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblATSGrades>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblATSHost>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAdditionalAmount>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAddress>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAdminCategory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblAdminDocument>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblAdminDocumentLetterType>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblAdminDocumentType>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblAdminLogDate>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });

                entity.Property(e => e.varTableName).IsUnicode(false);
            });

            modelBuilder.Entity<tblAdminUsers>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_AdminUsers");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAdminlogin>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAgeGroup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblAgreement>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAgreementDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAlertLog>(entity =>
            {
                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAlertsAndNotificationDays>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAllPages>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblAllowLeaveType>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblAllowanceStructure>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAnnouncement>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAnnouncementDetailed>(entity =>
            {
                entity.HasIndex(e => new { e.intEmployeeId, e.intCompanyId })
                    .HasName("missing_index_112");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAnnouncementEmail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAnualBalance>(entity =>
            {
                entity.HasIndex(e => e.intCompanyId)
                    .HasName("IX_tblAnualBalance");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblApplyOPDESS>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblApplyRoster>(entity =>
            {
                entity.HasIndex(e => new { e.intShiftId, e.intRosterMasterId })
                    .HasName("IX_tblApplyRoster_1");

                entity.HasIndex(e => new { e.intMasterId, e.intEmpid, e.intShiftId, e.intCompanyId, e.intRosterMasterId })
                    .HasName("IX_tblApplyRoster");

                entity.HasIndex(e => new { e.intShiftId, e.intRosterMasterId, e.intCompanyId, e.intEmpid, e.ShiftDate })
                    .HasName("missing_index_524280");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblApplyRosterMaster>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblApprovalOvertime>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblAssDesignation>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAssignmentNew>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAtsUserClients>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAttendanceAdjustment>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.dtStartDate, e.dtEndDate, e.intEmployeeId, e.intEarlyOuts, e.intLatesIns, e.intMissingTimes, e.isAdjusted })
                    .HasName("IX_tblAttendanceAdjustment");
            });

            modelBuilder.Entity<tblAttendanceAllowance>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.intRowNumId).IsFixedLength();
            });

            modelBuilder.Entity<tblAttendanceAllowanceDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.HasOne(d => d.intAttendanceAllowanceNavigation)
                    .WithMany(p => p.tblAttendanceAllowanceDetail)
                    .HasForeignKey(d => d.intAttendanceAllowance)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblAttendanceAllowanceDetail_tblAttendanceAllowance");
            });

            modelBuilder.Entity<tblAttendanceEmailLog>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAttendanceInOut>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intEmployeeId, e.dtClockIn, e.intCompanyId })
                    .HasName("IX_tblAttendanceInOut_1");

                entity.HasIndex(e => new { e.dtClockIn, e.dtClockOut, e.intEmployeeId, e.intCompanyId, e.dtDate })
                    .HasName("missing_index_22");

                entity.HasIndex(e => new { e.dtDate, e.intEmployeeId, e.dtClockIn, e.dtClockOut, e.intBranchID })
                    .HasName("IX_tblAttendanceInOut");

                entity.HasIndex(e => new { e.dtDate, e.dtClockOut, e.intBranchID, e.intCreatedBy, e.dtCreationDate, e.intUpdatedBy, e.dtUpdationDate, e.intShiftID, e.dtFromShiftTime, e.dtToShiftTime, e.intOverTimeDetailID, e.isClockManual, e.intInOut, e.dtBreakStart, e.dtBreakEnd, e.dtBreakStartAssign, e.dtBreakEndAssign, e.intEmployeeId, e.intCompanyId, e.dtClockIn })
                    .HasName("missing_index_1077");

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblAttendanceLeaveSummary_Report>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblAttendanceLeaveSummary_Report_1");
            });

            modelBuilder.Entity<tblAttendanceLog>(entity =>
            {
                entity.HasIndex(e => e.dtTime)
                    .HasName("IX_tblAttendanceLog_1");

                entity.HasIndex(e => new { e.dtDate, e.intEmployeeId, e.intCompanyId })
                    .HasName("missing_index_1");

                entity.HasIndex(e => new { e.dtDate, e.isSaved, e.intCompanyId })
                    .HasName("IX_AttLog_11");

                entity.HasIndex(e => new { e.intEmployeeId, e.intCompanyId, e.isSaved, e.dtDate, e.isMode, e.varType, e.intBranchId })
                    .HasName("IX_tblAttendanceLog");

                entity.HasIndex(e => new { e.dtDate, e.dtTime, e.intEmployeeId, e.isMode, e.dtCreationDate, e.varType, e.intBranchId, e.varDeviceIp, e.varDeviceId, e.isSaved, e.intCompanyId })
                    .HasName("missing_index_83293");

                entity.Property(e => e.varDeviceId).IsUnicode(false);

                entity.Property(e => e.varDeviceIp).IsUnicode(false);

                entity.Property(e => e.varType).IsUnicode(false);
            });

            modelBuilder.Entity<tblAttendanceLogTemp>(entity =>
            {
                entity.Property(e => e.varDeviceId).IsUnicode(false);

                entity.Property(e => e.varDeviceIp).IsUnicode(false);

                entity.Property(e => e.varType).IsUnicode(false);
            });

            modelBuilder.Entity<tblAttendanceMissingTemplate>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblAttendanceWatcher>(entity =>
            {
                entity.Property(e => e.IntSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblAuditLogEmailCheck>(entity =>
            {
                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBank>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblBankLetterFooter>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBankLetterHeader>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBehaviourChart>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblBenefit>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBenefitAmount>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyID, e.intMasterId })
                    .HasName("missing_index_382");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBenefitDetail>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblBenefitDetail_1");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBenefitMaster>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblBenefitDetail");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBillingReimbursement>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBillingRemType>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBin>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });

                entity.Property(e => e.varAbbrevation).IsUnicode(false);

                entity.Property(e => e.varBin).IsUnicode(false);
            });

            modelBuilder.Entity<tblBlog>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBloodRelation>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBookPlacement>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblBooks>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblBranch>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => e.varBranchName)
                    .HasName("IX_tblBranch");
            });

            modelBuilder.Entity<tblBroadArea>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblBroadAreaDetail>(entity =>
            {
                entity.HasIndex(e => new { e.intMasterId, e.intCompanyId })
                    .HasName("missing_index_770");

                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBroadAreaMaster>(entity =>
            {
                entity.HasIndex(e => new { e.intEmployeeID, e.varStatus })
                    .HasName("missing_index_108");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblBusManagement>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblCPR>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblCallMgmt>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblCandidateCertification>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCandidateEmailLog>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCandidateExperience>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCandidateLog>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCandidatePost>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCandidateQualification>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCandidateQuestionnaire>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCandidateStatus>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblCareerPathDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblCareerPathMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblCatagoryNew>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblCategory>(entity =>
            {
                entity.Property(e => e.intseqid).ValueGeneratedNever();

                entity.Property(e => e.varCategory).IsUnicode(false);
            });

            modelBuilder.Entity<tblCategoryManagement>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });

                entity.Property(e => e.varDescription).IsUnicode(false);

                entity.Property(e => e.varName).IsUnicode(false);
            });

            modelBuilder.Entity<tblCauseNotice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.varCause).IsUnicode(false);
            });

            modelBuilder.Entity<tblCauseNoticeEmployee>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblChangeStatus>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCheckListChild>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCheckListChildDepartment>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCheckListMaster>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblChildDep>(entity =>
            {
                entity.HasKey(e => e.intSubDepId)
                    .HasName("PK__tblChild__0F7F5569093B8BFB");

                entity.Property(e => e.varName).IsUnicode(false);

                entity.HasOne(d => d.intDep)
                    .WithMany(p => p.tblChildDep)
                    .HasForeignKey(d => d.intDepId)
                    .HasConstraintName("FK__tblChildD__intDe__7385F1B0");
            });

            modelBuilder.Entity<tblCity>(entity =>
            {
                entity.HasKey(e => new { e.varCountry, e.varState, e.varCity });
            });

            modelBuilder.Entity<tblClass>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });

                entity.Property(e => e.varAbbreviation).IsUnicode(false);

                entity.Property(e => e.varClassName).IsUnicode(false);

                entity.Property(e => e.varDescription).IsUnicode(false);
            });

            modelBuilder.Entity<tblClient>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intComapnyId });
            });

            modelBuilder.Entity<tblClosing>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblComments>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblCommission>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblCommissionESS>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblCommissionType>(entity =>
            {
                entity.Property(e => e.intSeqId).IsFixedLength();
            });

            modelBuilder.Entity<tblCompAlertEmail>(entity =>
            {
                entity.Property(e => e.intseqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCompAttendanceEmail>(entity =>
            {
                entity.Property(e => e.intseqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCompAttendanceEmailEmployeeList>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intEmployeeId, e.varEmail, e.intCompanyId, e.dtTime })
                    .HasName("missing_index_12052");
            });

            modelBuilder.Entity<tblCompany>(entity =>
            {
                entity.HasIndex(e => new { e.varCompanyName, e.isActive, e.varPhone, e.varEmail, e.intGroupId, e.varHeaderImage })
                    .HasName("IX_tblCompany");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.varAddress).IsUnicode(false);

                entity.Property(e => e.varBannerImage).IsUnicode(false);

                entity.Property(e => e.varCity).IsUnicode(false);

                entity.Property(e => e.varCode).IsUnicode(false);

                entity.Property(e => e.varCompanyName).IsUnicode(false);

                entity.Property(e => e.varCompanyType).IsUnicode(false);

                entity.Property(e => e.varCompanyUrl).IsUnicode(false);

                entity.Property(e => e.varCountry).IsUnicode(false);

                entity.Property(e => e.varCurrency).IsUnicode(false);

                entity.Property(e => e.varDateFormat).IsUnicode(false);

                entity.Property(e => e.varEmail).IsUnicode(false);

                entity.Property(e => e.varHeaderImage).IsUnicode(false);

                entity.Property(e => e.varLink).IsUnicode(false);

                entity.Property(e => e.varNtn).IsUnicode(false);

                entity.Property(e => e.varPerson1Address).IsUnicode(false);

                entity.Property(e => e.varPerson2Address).IsUnicode(false);

                entity.Property(e => e.varPhone).IsUnicode(false);

                entity.Property(e => e.varState).IsUnicode(false);

                entity.Property(e => e.varTimeZone).IsUnicode(false);

                entity.Property(e => e.varTotalEmployee).IsUnicode(false);

                entity.Property(e => e.varpayrollImage).IsUnicode(false);

                entity.Property(e => e.varperson1Email).IsUnicode(false);

                entity.Property(e => e.varperson1Name).IsUnicode(false);

                entity.Property(e => e.varperson1Phone).IsUnicode(false);

                entity.Property(e => e.varperson2Email).IsUnicode(false);

                entity.Property(e => e.varperson2Name).IsUnicode(false);

                entity.Property(e => e.varperson2Phone).IsUnicode(false);
            });

            modelBuilder.Entity<tblCompanyLetterHeader>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCompanyModule>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCompanyOff>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblCompanyOffMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblCompanyRights>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCompanyType>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblCompensationAttendance>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.isApprove, e.intEmployeeId, e.intCompanyId, e.dtCompensationDate })
                    .HasName("missing_index_35");
            });

            modelBuilder.Entity<tblCompensationLeave>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblComplainType>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblContactDBFormDetail>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblConta__902531BA54944C30");

                entity.Property(e => e.varCellNo).IsUnicode(false);

                entity.Property(e => e.varEmailId).IsUnicode(false);

                entity.Property(e => e.varEmployeeName).IsUnicode(false);

                entity.Property(e => e.varExtNo).IsUnicode(false);

                entity.HasOne(d => d.intMaster)
                    .WithMany(p => p.tblContactDBFormDetail)
                    .HasForeignKey(d => d.intMasterId)
                    .HasConstraintName("FK__tblContac__intMa__784AA6CD");
            });

            modelBuilder.Entity<tblContactDBFormMaster>(entity =>
            {
                entity.HasKey(e => e.intSeqid)
                    .HasName("PK__tblConta__90240D9225002FCA");
            });

            modelBuilder.Entity<tblContactLedge>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblContactUs>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.varName).IsUnicode(false);
            });

            modelBuilder.Entity<tblCountry>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblCurrency>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblCustomAlerts>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCustomers>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.Property(e => e.isDefault).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tblDailyAttendanceAdjustment>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDailyManualAllowance>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyId, e.dtFromDate, e.dtToDate, e.intEmpID, e.varType })
                    .HasName("IX_tblDailyManualAllowance");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDailyManualAttendance>(entity =>
            {
                entity.HasIndex(e => new { e.varType, e.flDay1, e.flDay2, e.flDay3, e.flDay4, e.flDay5, e.flDay6, e.flDay7, e.flDay8, e.flDay9, e.flDay10, e.flDay11, e.flDay12, e.flDay13, e.flDay14, e.flDay15, e.flDay16, e.flDay17, e.flDay18, e.flDay19, e.flDay20, e.flDay21, e.flDay22, e.flDay23, e.flDay24, e.flDay25, e.flDay26, e.flDay27, e.flDay28, e.flDay29, e.flDay30, e.flDay31, e.flTotal, e.flTotalPresent, e.flTotalAbsent, e.flTotalHalfDay, e.flTotalQuarterDay, e.flTotalLeave, e.flTotalHalfLeave, e.flTotalQuarterLeave, e.flTotalHoliday, e.flTotalOFFDay, e.intCompanyId, e.dtFromDate, e.dtToDate, e.intEmpID })
                    .HasName("missing_index_93048");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDailyManualOT>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyId, e.dtFromDate, e.dtToDate, e.intEmpID, e.varType })
                    .HasName("IX_tblDailyManualOT");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDashboardSettings>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblDateOff>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intEmployeeId, e.intCompanyId, e.dtDate })
                    .HasName("missing_index_28445");

                entity.HasIndex(e => new { e.intEmployeeId, e.intMasterId, e.dtDate, e.intRefrId, e.intCompanyId })
                    .HasName("IX_tblDateOff");
            });

            modelBuilder.Entity<tblDateOffMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => e.intDepartment)
                    .HasName("IX_tblDateOffMaster");
            });

            modelBuilder.Entity<tblDaysIndicatorDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblDaysIndicatorMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblDeduction>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });

                entity.HasIndex(e => new { e.intDeductionTypeId, e.intBranchID, e.intMasterId })
                    .HasName("IX_tblDeduction");
            });

            modelBuilder.Entity<tblDeductionStructure>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDeductionType>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });

                entity.Property(e => e.intUpdateBy).IsFixedLength();
            });

            modelBuilder.Entity<tblDegree>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblDegreeATS>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblDemand>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDemandApprovalFlowSave>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDemandApprovalFlowSetUp>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDemandItemMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intCompanyId });

                entity.Property(e => e.intSeqid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblDemotion>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblDep>(entity =>
            {
                entity.HasKey(e => e.intDepId)
                    .HasName("PK__tblDep__86B112D6B73A4B3E");

                entity.Property(e => e.varDepName).IsUnicode(false);
            });

            modelBuilder.Entity<tblDepDocuments>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblDepartment>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => e.varName)
                    .HasName("IX_tblDepartment");

                entity.HasIndex(e => new { e.intCompanyId, e.intParentID })
                    .HasName("missing_index_13");
            });

            modelBuilder.Entity<tblDepartmentResignEmployee>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.Property(e => e.varTemplate).IsUnicode(false);
            });

            modelBuilder.Entity<tblDesig>(entity =>
            {
                entity.HasKey(e => e.intDesgId)
                    .HasName("PK__tblDesig__55A6C08A13222186");

                entity.Property(e => e.varName).IsUnicode(false);
            });

            modelBuilder.Entity<tblDesignation>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => e.varName)
                    .HasName("IX_tblDesignation");
            });

            modelBuilder.Entity<tblDetailManualSOP>(entity =>
            {
                entity.Property(e => e.IntseqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDeviceConfig>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblDeviceTemplate>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDocumentTemplate>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblDocumentTypeSetup>(entity =>
            {
                entity.Property(e => e.intSeqId).IsFixedLength();
            });

            modelBuilder.Entity<tblDonorContact>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblDriver>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblDriverBus>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblDriverBusHistory>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblDriverManagement>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblEOBIFund>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEarlyOutAuthorization>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEarlyOutRules>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEarlyOutRulesNew>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEarlyOutRulesNewProcess>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.IsActive3, e.intCompanyId, e.intEmployeeId, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_29");

                entity.HasIndex(e => new { e.intCompanyId, e.intEmployeeId, e.dtMonth, e.dtYear, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_5749");

                entity.HasIndex(e => new { e.IsActive1, e.intCompanyId, e.intEmployeeId, e.dtStartDate, e.dtEndDate, e.IntFromMint1, e.intToMint1 })
                    .HasName("missing_index_6528");

                entity.HasIndex(e => new { e.IsActive2, e.intCompanyId, e.intEmployeeId, e.dtStartDate, e.dtEndDate, e.IntFromMint2, e.intToMint2 })
                    .HasName("missing_index_1934");
            });

            modelBuilder.Entity<tblEmail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmailControl>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmailFooter>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmailRecord>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmailReminder>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmailSetting>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblEmailSetting_1");
            });

            modelBuilder.Entity<tblEmailStatus>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intEmployeeId, e.isEmailDaily })
                    .HasName("IX_tblEmailStatus");

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblEmailTemplates>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmpAttendanceLive>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.dtTime, e.intCompanyId })
                    .HasName("missing_index_4570");

                entity.HasIndex(e => new { e.intShiftId, e.Mode })
                    .HasName("IX_tblEmpAttendanceLive_1");

                entity.HasIndex(e => new { e.intEmployeeId, e.dtDate, e.dtTime })
                    .HasName("IX_tblEmpAttendanceLive");

                entity.HasIndex(e => new { e.dtDate, e.intEmployeeId, e.intRefId, e.intShiftId, e.dtStartTime, e.dtEndTime, e.Mode, e.dtTime, e.intCompanyId })
                    .HasName("missing_index_47400");

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();

                entity.Property(e => e.Mode).IsUnicode(false);
            });

            modelBuilder.Entity<tblEmpContacts>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpDePromotion>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpDocuments>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intEmployeeId, e.intCompanyId })
                    .HasName("IX_EmpDoc_11");
            });

            modelBuilder.Entity<tblEmpExit>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.Property(e => e.dtCreationDate).IsFixedLength();
            });

            modelBuilder.Entity<tblEmpExperience>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpFamilyInfo>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intComanyID });

                entity.Property(e => e.intEmployeeId).IsFixedLength();
            });

            modelBuilder.Entity<tblEmpFeedback>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpHealthInsurrance>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpIncrements>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intComapnyId });
            });

            modelBuilder.Entity<tblEmpJobDesc>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmpLeavesHistory>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpMedicalTaxHistroy>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpPromotion>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpReferences>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmpStatus>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => e.intEmployeeId)
                    .HasName("IX_tblEmpStatus");
            });

            modelBuilder.Entity<tblEmployeeAssignGoal>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmployeeAssignGoalDetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmployeeAssignGoalDetailSendRequest>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmployeeAssignGoalMsterNew>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmployeeAssociation>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmployeeAttendance>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intBranchID, e.dtFromShiftTime, e.dtToShiftTime })
                    .HasName("IX_tblEmployeeAttendance_1");

                entity.HasIndex(e => new { e.intEmployeeId, e.intCompanyId, e.dtDate })
                    .HasName("missing_index_103");

                entity.HasIndex(e => new { e.intEmployeeId, e.dtClockIn, e.dtFromShiftTime, e.intCompanyId, e.dtDate })
                    .HasName("missing_index_2199790");

                entity.HasIndex(e => new { e.intEmployeeId, e.dtDate, e.intCompanyId, e.dtClockIn, e.dtClockOut })
                    .HasName("IX_EmpAtt_11");

                entity.HasIndex(e => new { e.dtDate, e.dtClockIn, e.dtClockOut, e.dtFromShiftTime, e.dtToShiftTime, e.intEmployeeId, e.intCompanyId })
                    .HasName("missing_index_998");

                entity.HasIndex(e => new { e.intEmployeeId, e.dtClockIn, e.dtClockOut, e.dtDate, e.isClockManual, e.isLateAuthorize, e.isMissingAuthorize })
                    .HasName("IX_tblEmployeeAttendance");

                entity.HasIndex(e => new { e.dtDate, e.dtClockOut, e.intBranchID, e.intCreatedBy, e.dtCreationDate, e.intUpdatedBy, e.dtUpdationDate, e.intShiftID, e.dtFromShiftTime, e.dtToShiftTime, e.intOverTimeDetailID, e.isClockManual, e.intInOut, e.dtBreakStart, e.dtBreakEnd, e.dtBreakStartAssign, e.dtBreakEndAssign, e.varReasonIn, e.varReasonOut, e.intWorkingHour, e.intAdjustedLeaveId, e.LeaveVal, e.varClockInLatitude, e.varClockOutLatitude, e.varClockInLongitude, e.varClockOutLongitude, e.isLateAuthorize, e.isMissingAuthorize, e.isOffDayAttendance, e.intEmployeeId, e.intCompanyId, e.dtClockIn })
                    .HasName("missing_index_4590");

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();

                entity.Property(e => e.varClockInLatitude).IsUnicode(false);

                entity.Property(e => e.varClockInLongitude).IsUnicode(false);

                entity.Property(e => e.varClockOutLatitude).IsUnicode(false);

                entity.Property(e => e.varClockOutLongitude).IsUnicode(false);

                entity.Property(e => e.varReasonIn).IsUnicode(false);

                entity.Property(e => e.varReasonOut).IsUnicode(false);
            });

            modelBuilder.Entity<tblEmployeeBackgroundCheck>(entity =>
            {
                entity.Property(e => e.intSeqid).ValueGeneratedNever();

                entity.Property(e => e.varFilePath).IsUnicode(false);
            });

            modelBuilder.Entity<tblEmployeeCheckListApproved>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeChild>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });
            });

            modelBuilder.Entity<tblEmployeeClearanceCheckListApproved>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeComplains>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeComplaints>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmployeeFields>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeFieldsDtl>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmployeeFine>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblEmployeeFine_1");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeItemAssign>(entity =>
            {
                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeJobPost>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeJobRequest>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_dbo.tblEmployeeJobRequest");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeLeaveQouta>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblStudentLeaveQouta");

                entity.HasIndex(e => new { e.intEmployeeId, e.intLeaveTypeId })
                    .HasName("IX_tblEmployeeLeaveQouta");
            });

            modelBuilder.Entity<tblEmployeeLoanDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intMasterId, e.intMonth, e.intYear })
                    .HasName("IX_tblEmployeeLoanDetail");
            });

            modelBuilder.Entity<tblEmployeeLoanDetailMerge>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intMonth, e.intYear, e.intMasterId, e.intCompanyId })
                    .HasName("missing_index_61969");
            });

            modelBuilder.Entity<tblEmployeeLoanMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => e.intEmployeeId)
                    .HasName("IX_tblEmployeeLoanMaster");
            });

            modelBuilder.Entity<tblEmployeeMgmt>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblEmployeeInfo");

                entity.HasIndex(e => new { e.intWorkingHour, e.flAttendancePercent })
                    .HasName("IX_tblEmployeeMgmt_2");

                entity.HasIndex(e => new { e.varFirstName, e.isActive, e.intCompanyId })
                    .HasName("missing_index_120");

                entity.HasIndex(e => new { e.intCompanyId, e.intBranchID, e.dtJoiningDate, e.isActive })
                    .HasName("missing_index_979782");

                entity.HasIndex(e => new { e.isActive, e.intReportedTo, e.intOtherReportedTo, e.intCompanyId })
                    .HasName("IX_EmpMgmt_11");

                entity.HasIndex(e => new { e.isActive, e.intReportedTo, e.dtConfirmationDate, e.dtContractEnd, e.dtContractExpire, e.intEmployeeType, e.intSalaryID })
                    .HasName("IX_tblEmployeeMgmt_1");

                entity.HasIndex(e => new { e.varFirstName, e.intDesignation, e.varImagePath, e.intDepartmentID, e.isActive, e.dtPayReviewDate, e.intCompanyId })
                    .HasName("missing_index_977554");

                entity.HasIndex(e => new { e.intWorkingHour, e.dtDateOfBirth, e.dtJoiningDate, e.intDepartmentID, e.intBranchID, e.intAttendanceType, e.intDesignation, e.intEmployeeType, e.intReportedTo, e.varPayBy })
                    .HasName("IX_tblEmployeeMgmt");

                entity.Property(e => e.intShiftID).IsUnicode(false);

                entity.Property(e => e.varAddress1).IsUnicode(false);

                entity.Property(e => e.varAddress2).IsUnicode(false);

                entity.Property(e => e.varBankAc).IsUnicode(false);

                entity.Property(e => e.varCNIC).IsUnicode(false);

                entity.Property(e => e.varDependent).IsUnicode(false);

                entity.Property(e => e.varDrivingLiscNo).IsUnicode(false);

                entity.Property(e => e.varEOBINo).IsUnicode(false);

                entity.Property(e => e.varEmail).IsUnicode(false);

                entity.Property(e => e.varEmailPvt).IsUnicode(false);

                entity.Property(e => e.varExperience).IsUnicode(false);

                entity.Property(e => e.varFamily).IsUnicode(false);

                entity.Property(e => e.varFatherCNIC).IsUnicode(false);

                entity.Property(e => e.varFatherName).IsUnicode(false);

                entity.Property(e => e.varGrade).IsUnicode(false);

                entity.Property(e => e.varImagePath).IsUnicode(false);

                entity.Property(e => e.varInsurance).IsUnicode(false);

                entity.Property(e => e.varLivingWith).IsUnicode(false);

                entity.Property(e => e.varMarkOfIdentity).IsUnicode(false);

                entity.Property(e => e.varMarriageNo).IsUnicode(false);

                entity.Property(e => e.varMarriageWith).IsUnicode(false);

                entity.Property(e => e.varNTN).IsUnicode(false);

                entity.Property(e => e.varOthers).IsUnicode(false);

                entity.Property(e => e.varPermPhone).IsUnicode(false);

                entity.Property(e => e.varPhone).IsUnicode(false);

                entity.Property(e => e.varSex).IsUnicode(false);

                entity.Property(e => e.varSocialSecurityNo).IsUnicode(false);

                entity.Property(e => e.varSuitable).IsUnicode(false);

                entity.Property(e => e.varTimeZone).IsUnicode(false);
            });

            modelBuilder.Entity<tblEmployeeOnBoard>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeOnBoarding>(entity =>
            {
                entity.Property(e => e.varEmail).IsUnicode(false);
            });

            modelBuilder.Entity<tblEmployeeOnBoardingExperienceDetails>(entity =>
            {
                entity.Property(e => e.contactNo).IsUnicode(false);
            });

            modelBuilder.Entity<tblEmployeeOnBoardingReasons>(entity =>
            {
                entity.Property(e => e.linkKey).IsUnicode(false);

                entity.Property(e => e.reason).IsUnicode(false);
            });

            modelBuilder.Entity<tblEmployeeOvertimeFlow>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmployeeResignFlow>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblEmployeeSetting>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEmployeeTransfer>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEmployeeType>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });
            });

            modelBuilder.Entity<tblEmployeerQualification>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblTeacherQualification");
            });

            modelBuilder.Entity<tblEmployementHistory>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEobiDays>(entity =>
            {
                entity.HasKey(e => e.intSeqID)
                    .HasName("PK_tblEobiDays_1");

                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEssEmail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblEssMultipleEmployee>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEssNotification>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblEssloginLogout>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblExceptionDetails>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblExpenceMgmt>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblExpenceMgmtESS>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblExpenceType>(entity =>
            {
                entity.Property(e => e.intSeqId).IsFixedLength();
            });

            modelBuilder.Entity<tblExpenseDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblExpenseFlowEmployee>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblFAQ>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFAQAdvance>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFAQAssets>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblFAQAttend>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFAQESS>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFAQPayroll>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFAQReport>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFAQSetup>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFeeHeads>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblFieldsSetting>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblFileImage>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.intSeqid, e.varfileName, e.isApprproved, e.intCompanyId, e.intMasterId })
                    .HasName("missing_index_122");
            });

            modelBuilder.Entity<tblFinalSettlement>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFineType>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblFineType_1");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFloaterLeave>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblFloaterLeaveEmail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblFuel>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblGeneralContacts>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblGoalsObjectiveDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblGoalsObjectivemaster>(entity =>
            {
                entity.Property(e => e.intseqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblGrades>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblGroupControl>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });
            });

            modelBuilder.Entity<tblHREmailSetting>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblHelpDeskDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblHelpDeskMaster>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.ID)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(right('000000'+CONVERT([varchar](6),[intSeqId],(0)),(6)))");
            });

            modelBuilder.Entity<tblHelpDeskType>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblHostelLocation>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblIPS>(entity =>
            {
                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblIncentive>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });

                entity.HasIndex(e => new { e.intCompanyID, e.intMasterId })
                    .HasName("missing_index_2540");

                entity.HasIndex(e => new { e.intBranchID, e.intMasterId, e.intIncentiveTypeId })
                    .HasName("IX_tblIncentive");
            });

            modelBuilder.Entity<tblIncentiveTaxMgmt>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblIncentiveType>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblIncomingCalls>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblIncom__902531BACE25162E");

                entity.Property(e => e.varSubject).IsUnicode(false);
            });

            modelBuilder.Entity<tblIncrement>(entity =>
            {
                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblIncrementStatus>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblInstallmentDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblInstallmentMaster>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblInternetBillReimbursement>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblInternetBillRemType>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblInventory>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.isAddon).HasDefaultValueSql("((0))");

                entity.Property(e => e.varBrand).IsFixedLength();
            });

            modelBuilder.Entity<tblIssueBookDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblIssueBookMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyId });
            });

            modelBuilder.Entity<tblIssueDetail>(entity =>
            {
                entity.Property(e => e.intSeqid).ValueGeneratedNever();

                entity.Property(e => e.varType).IsUnicode(false);
            });

            modelBuilder.Entity<tblIssueMaster>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.varType).IsUnicode(false);
            });

            modelBuilder.Entity<tblItem>(entity =>
            {
                entity.HasKey(e => new { e.intItemId, e.intCompanyId });

                entity.Property(e => e.intPurchaseItemUnit).HasDefaultValueSql("((0))");

                entity.Property(e => e.intSellingItemUnit).HasDefaultValueSql("((0))");

                entity.Property(e => e.intWareHouse).HasDefaultValueSql("((0))");

                entity.Property(e => e.strIngredient).HasDefaultValueSql("('')");

                entity.Property(e => e.varBin).HasDefaultValueSql("('')");

                entity.Property(e => e.varSKUcode).HasDefaultValueSql("('')");

                entity.Property(e => e.varShelve).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<tblItemCatgory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblItemIssueDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intCompanyId });
            });

            modelBuilder.Entity<tblItemIssueMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intCompanyId });

                entity.Property(e => e.varVoucher).IsFixedLength();
            });

            modelBuilder.Entity<tblItemRate>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblRate");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblItemRateCustom>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblItems>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblAssets");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblJobDescription>(entity =>
            {
                entity.Property(e => e.intSeqId).IsFixedLength();
            });

            modelBuilder.Entity<tblJobNumber>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblJobPostEmails>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblJobPostNotify>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblJobRequest>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblJobRequestDetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblLanguage>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblLateAllowance>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.intRowNumId).IsFixedLength();
            });

            modelBuilder.Entity<tblLateAllowanceDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.HasOne(d => d.intLateAllowanceNavigation)
                    .WithMany(p => p.tblLateAllowanceDetail)
                    .HasForeignKey(d => d.intLateAllowance)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblLateAllowanceDetail_tblLateAllowance");
            });

            modelBuilder.Entity<tblLateAttendanceExemption>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblLateEmailControl>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLateInAuthorization>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLateInRules>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblLatinRules");

                entity.HasIndex(e => e.intLeaveTypeId)
                    .HasName("IX_tblLateInRules");
            });

            modelBuilder.Entity<tblLateInRulesNew>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblLatinRulesNew");
            });

            modelBuilder.Entity<tblLateInRulesNewProcess>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblLatinRulesNewProcess");

                entity.HasIndex(e => new { e.IsActive2, e.intCompanyId, e.intEmployeeId, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_137");

                entity.HasIndex(e => new { e.IsActive3, e.intCompanyId, e.intEmployeeId, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_139");

                entity.HasIndex(e => new { e.IsActive1, e.intCompanyId, e.intEmployeeId, e.dtStartDate, e.dtEndDate, e.IntFromMint1, e.intToMint1 })
                    .HasName("missing_index_3820");
            });

            modelBuilder.Entity<tblLateInRulesProcess>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblLatinRulesProcess");

                entity.HasIndex(e => new { e.dtFromDate, e.dtToDate })
                    .HasName("IX_tblLateInRulesProcess");

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblLateInSlabs>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblLateI__902531BAA5CF16BC");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLeaveApprovalFlowSave>(entity =>
            {
                entity.HasIndex(e => new { e.intLeaveSeqId, e.isApprove, e.intCompanyId })
                    .HasName("missing_index_416");

                entity.HasIndex(e => new { e.intLeaveSeqId, e.intApprovalId, e.isApprove, e.intCompanyId })
                    .HasName("missing_index_495");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLeaveApprovalFlowSetUp>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyId, e.intEmployeeId, e.intLeaveTypeId })
                    .HasName("missing_index_1");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLeaveCount>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intEmployeeId, e.intLeaveSeqId, e.dtStartDate, e.intCompanyId })
                    .HasName("missing_index_25");

                entity.HasIndex(e => new { e.intLeaveSeqId, e.dtStartDate, e.intEmployeeId, e.intCompanyId })
                    .HasName("missing_index_67");

                entity.HasIndex(e => new { e.intLeaveSeqId, e.intEmployeeId, e.dtStartDate, e.dtEndDate, e.intLeaveTypeId, e.flVal, e.isAppRejDetail, e.LeaveStatus })
                    .HasName("IX_tblLeaveCount");

                entity.Property(e => e.LeaveStatus).IsUnicode(false);
            });

            modelBuilder.Entity<tblLeaveEmailCCSetting>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLeaveEncashment>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLeaveTamplateNew>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblLeaveTamplate");
            });

            modelBuilder.Entity<tblLeaveTemplateDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblLeaveTemplateMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblLeaveType>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });

                entity.HasIndex(e => new { e.isActive, e.isESS, e.isApplyToAll, e.isPaid })
                    .HasName("IX_tblLeaveType");
            });

            modelBuilder.Entity<tblLeaves>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID })
                    .HasName("PK_tblHolidays");

                entity.HasIndex(e => new { e.isAppRej, e.intCompanyID, e.intMasterId })
                    .HasName("IX_tblLeaves_1");

                entity.HasIndex(e => new { e.intMasterId, e.isAppRej, e.intCompanyID, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_538446");

                entity.HasIndex(e => new { e.intDays, e.isAppRej, e.intCompanyID, e.intMasterId, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_116");

                entity.HasIndex(e => new { e.isAppRej, e.dtLeaveEndPeriod, e.dtLeaveStartPeriod, e.intBranchID, e.intLeavePeriodId, e.intMasterId })
                    .HasName("IX_tblLeaves");

                entity.HasIndex(e => new { e.intDays, e.isAppRej, e.intCompanyID, e.intMasterId, e.intLeaveType, e.intLeavePeriodId, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_406858");

                entity.HasIndex(e => new { e.varReason, e.dtStartDate, e.dtEndDate, e.intDays, e.intCreatedBy, e.intBranchID, e.dtCreationDate, e.dtUpdateDate, e.intUpdateBy, e.intLeaveType, e.isAppRej, e.intAppRejBy, e.dtAppRejDate, e.varAppRejDetails, e.dtLeaveEndPeriod, e.dtLeaveStartPeriod, e.varFilePath1, e.varFilePath2, e.varFilePath3, e.intLeavePeriodId, e.varDayType, e.vartype, e.dtFromTime, e.dtToTime, e.LeaveStatus, e.var1stHalf2ndHalf, e.dtAgainstDate, e.dtAgainstDateClockIn, e.dtAgainstDateClockOut, e.intBloodRelation, e.varCompansationType, e.intCompanyID, e.intMasterId })
                    .HasName("missing_index_8934");

                entity.Property(e => e.LeaveStatus).IsUnicode(false);

                entity.Property(e => e.var1stHalf2ndHalf).IsUnicode(false);

                entity.Property(e => e.varAppRejDetails).IsUnicode(false);

                entity.Property(e => e.varDayType).IsUnicode(false);

                entity.Property(e => e.varFilePath1).IsUnicode(false);

                entity.Property(e => e.varFilePath2).IsUnicode(false);

                entity.Property(e => e.varFilePath3).IsUnicode(false);

                entity.Property(e => e.vartype).IsUnicode(false);
            });

            modelBuilder.Entity<tblLeavesPeriod>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblLetterOfThanksTemplate>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.Property(e => e.varBody).IsUnicode(false);
            });

            modelBuilder.Entity<tblLoan>(entity =>
            {
                entity.HasIndex(e => new { e.intEmpId, e.VarEmployeeType, e.isRecomended, e.intCompanyId })
                    .HasName("missing_index_326991");
            });

            modelBuilder.Entity<tblLoanAjustDetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblLoanModuleFlowSetUp>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLoanModuleFlowSetUpEmployee>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLoanPurpose>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLoanRequest>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLoanRequestDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLocation>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblLocationMgmt");
            });

            modelBuilder.Entity<tblLocationMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblLocationWareHouse>(entity =>
            {
                entity.HasKey(e => e.intSeqID)
                    .HasName("PK_tblLocation");

                entity.HasIndex(e => e.varName)
                    .HasName("IX_tblLocation")
                    .IsUnique();

                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblLog>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblLogDate>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });

                entity.HasIndex(e => new { e.intRecordId, e.varAction, e.varTableName, e.intUserId, e.intCompanyID, e.dtCreationDate })
                    .HasName("missing_index_618262");

                entity.HasIndex(e => new { e.intUserId, e.dtCreationDate, e.varAction, e.varTableName, e.intReferenceID, e.varType, e.intRecordMasterId, e.varIPAddress, e.intRecordId, e.intCompanyID })
                    .HasName("missing_index_63010");

                entity.Property(e => e.varTableName).IsUnicode(false);
            });

            modelBuilder.Entity<tblLoginHistory>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.intSeqId, e.intUserId, e.dtLoginTime, e.varIpAddress, e.intEmployeeid, e.intClientId, e.isMobile, e.varType, e.intCompanyid })
                    .HasName("missing_index_117524");
            });

            modelBuilder.Entity<tblLubricants>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblMainContactPerson>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblMaintance>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblManagerAuthorised>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.Property(e => e.isDefault).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tblManualAtendanceRights>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblManualAttReason>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblManualAttendanceEss>(entity =>
            {
                entity.HasIndex(e => new { e.intReasonId, e.intCompanyId, e.intEmployeeId, e.dtDate, e.varType })
                    .HasName("IX_tblManualAttendanceEss");

                entity.HasIndex(e => new { e.dtClockIn, e.dtClockOut, e.intEmployeeId, e.isApprove, e.intCompanyId, e.dtDate })
                    .HasName("missing_index_98121");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.varType).IsUnicode(false);
            });

            modelBuilder.Entity<tblManualSOPUpload>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblManualnSOP>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblMedicalAllowance>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblMedicalOpening>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblMedicalPeriod>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblMenualBreak>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tbl");
            });

            modelBuilder.Entity<tblModuleRights>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblModules>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblMonths>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblMyMail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblNationality>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblNews>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });
            });

            modelBuilder.Entity<tblNewsletter>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.varEmail).IsFixedLength();
            });

            modelBuilder.Entity<tblNotice>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblNotice_1");
            });

            modelBuilder.Entity<tblNumbers>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOPDEmployee>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblOPDGrade>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOPDHealthPeriod>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOPDOpening>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOPDWithDraw>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblOTPGenerator>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOffBoarding>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOnBoarding>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOpeningBalance>(entity =>
            {
                entity.HasIndex(e => new { e.intEmployeeid, e.intCompanyid })
                    .HasName("IX_tblOpeningBalance");

                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOpeningEOBI>(entity =>
            {
                entity.HasIndex(e => new { e.intSeqid, e.intEmployeeid, e.intCompanyid })
                    .HasName("IX_tblOpeningEOBI");

                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOpeningSocailSecurity>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyid, e.intEmployeeid })
                    .HasName("IX_tblOpeningSocailSecurity");

                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOpeningTax>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intCompanyid });

                entity.HasIndex(e => new { e.intCompanyid, e.intEmployeeid })
                    .HasName("IX_tblOpeningTax");
            });

            modelBuilder.Entity<tblOrderMgmt>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.intReceivable).HasDefaultValueSql("((1))");

                entity.Property(e => e.varAdvanceRemarks).IsUnicode(false);

                entity.Property(e => e.varCNIC).IsUnicode(false);

                entity.Property(e => e.varCancelReason).IsUnicode(false);

                entity.Property(e => e.varCareOff).IsUnicode(false);

                entity.Property(e => e.varColdDrinkType).IsUnicode(false);

                entity.Property(e => e.varColorScheme).IsUnicode(false);

                entity.Property(e => e.varDesc).IsUnicode(false);

                entity.Property(e => e.varHall).IsUnicode(false);

                entity.Property(e => e.varHostPhone).IsUnicode(false);

                entity.Property(e => e.varMuttonType).IsUnicode(false);

                entity.Property(e => e.varNTN).IsUnicode(false);

                entity.Property(e => e.varSoundSupplier).IsUnicode(false);

                entity.Property(e => e.varStageSupplier).IsUnicode(false);

                entity.Property(e => e.varStatus).IsUnicode(false);

                entity.Property(e => e.varSubject).IsUnicode(false);

                entity.Property(e => e.varTotalGuestUnConfirmed).IsUnicode(false);

                entity.Property(e => e.varWaterType).IsUnicode(false);
            });

            modelBuilder.Entity<tblOverTime>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOverTimeApprove>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblOverTimeDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblOverTimeManual>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOverTimeMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblOverTimeRequestDetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblOverTimeRequestMaster>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblOvertimeApprovalDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblOvertimeSlabs>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPMSAdjustment>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSAnalysisData>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPMSApprovalFlowSave>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSApprovalFlowSetUp>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyId, e.intEmployeeId, e.varLevelType })
                    .HasName("missing_index_124");
            });

            modelBuilder.Entity<tblPMSDateWiseIncrement>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSFooterRemark>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSHistory>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSIncrementHistory>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSIndicatorMergeEss>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblPMSIndicatorMergeEss_1");

                entity.HasIndex(e => new { e.intBroadAreaMasterId, e.intCompanyId })
                    .HasName("missing_index_42291");

                entity.HasIndex(e => new { e.intManagerId, e.intMailMasterId, e.intCompanyId })
                    .HasName("missing_index_44320");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSMultipleDesignationGradeWise>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSPage>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSPageDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSParentIndicator>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSPeriodWise>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSScheduler>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSTaskCategory>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPMSTypeNew>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPMSWeitage>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPMSWorkConductBase>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPOSRecipe>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPages>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblParentBillingRemType>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblParents>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblPayRoll>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });

                entity.HasIndex(e => e.intEmpID)
                    .HasName("IX_tblPayRoll_1");

                entity.HasIndex(e => new { e.isProcess, e.varType, e.dtMonth, e.dtYear, e.isPaid })
                    .HasName("IX_tblPayRoll_2");

                entity.HasIndex(e => new { e.flTotal, e.isProcess, e.isPaid, e.intCompanyID, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_899");

                entity.HasIndex(e => new { e.intLeaves, e.dtEndDate, e.dtStartDate, e.intDepartmentID, e.intBranchID, e.intEmpID, e.intWD })
                    .HasName("IX_tblPayRoll");

                entity.HasIndex(e => new { e.intEmpID, e.isProcess, e.isVerified, e.isApproved, e.dtMonth, e.dtYear, e.intCompanyID, e.dtStartDate, e.dtEndDate, e.varType })
                    .HasName("missing_index_495");

                entity.HasIndex(e => new { e.intEmpID, e.intWD, e.flAtdDed, e.flIncentives, e.flDeductions, e.flOtherDeductions, e.flBasic, e.flAdvances, e.flBonus, e.flTotal, e.flOtAmount, e.flGivenLoanAmount, e.isProcess, e.varType, e.isPaid, e.flLeavesDed, e.flTaxDed, e.flLateDed, e.flAdvanceSalary, e.flShortAttendanceDeduction, e.flProvidentAmount, e.flPFLoanDed, e.flBYOD, e.flEmployeerProvident, e.flEmpEOBI, e.flComEOBI, e.flSocialSecurity, e.flSecurity, e.flLWOPDed, e.flMedicalReimbursement, e.flLeaveEncashGrossSal, e.flBenefits, e.intCompanyID, e.dtStartDate, e.dtEndDate })
                    .HasName("missing_index_4119");

                entity.HasIndex(e => new { e.intEmpID, e.intWD, e.flAtdDed, e.intLeaves, e.flIncentives, e.flDeductions, e.flOtherDeductions, e.flOtherBonus, e.flBasic, e.flAdvances, e.flBonus, e.flTotal, e.intDepartmentID, e.intBranchID, e.intCreatedBy, e.dtCreationDates, e.flRate, e.flOverTimeHours, e.flOtAmount, e.flGivenLoanAmount, e.isProcess, e.flRemarks, e.intAdjustDay, e.intWD1, e.dtEmailSentOn, e.isPaid, e.flLeavesDed, e.flTaxDed, e.flLateDed, e.flAdvanceSalary, e.flShortAttendanceDeduction, e.flShortAttendanceDeductionMints, e.flProvidentAmount, e.flPFLoanDed, e.flBYOD, e.flEmployeerProvident, e.flEmpEOBI, e.flComEOBI, e.flSocialSecurity, e.flSecurity, e.intVMasterId, e.flLWOPDed, e.dtPaidDate, e.flMedicalReimbursement, e.flAnnualBonus, e.flLeaveEncashGrossSal, e.flNegativeRemainingSalary, e.flArrearsPrevSalary, e.intProjectSetupId, e.flAttendanceMissingRuleAmount, e.flBenefits, e.workingDays, e.Days1, e.getTotalLate, e.LateRuleDayOffEmp, e.isPrepared, e.intPreparedBy, e.dtPreparedDate, e.isVerified, e.intVerifiedBy, e.dtVerifiedDate, e.isApproved, e.intApprovedBy, e.dtApprovedDate, e.flNormalOverTimeRate, e.flNormalOverTimeAdjustmentMint, e.flNormalOverTimeMint, e.flNormalOverTimeAmount, e.flWeekendOverTimeRate, e.flWeekendOverTimeAdjustmentMint, e.flWeekendOverTimeMint, e.flWeekendOverTimeAmount, e.isTaxableBonusPayroll, e.isTaxableBYODPayroll, e.isTaxableMedicalReimbursementPayroll, e.isTaxableLeaveEncashmentPayroll, e.flOPD, e.intDesignationId, e.flCustomColumn5, e.flCustomColumn6, e.flAdjustmentAmount, e.flAdjustmentDays, e.flFixedLateDays, e.flNetSalaryAmount, e.flEarnedSalaryAmount, e.isAdjustment, e.flShortDaysDed, e.flShortDaysDedAmount, e.isPFAllowWithIncentive, e.dtMonth, e.dtYear, e.intCompanyID, e.dtStartDate, e.dtEndDate, e.varType })
                    .HasName("missing_index_457");

                entity.Property(e => e.intVMasterId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tblPayRollDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intDeductionTypeId, e.dtMonth, e.dtYear, e.intIncentiveTypeId, e.intEmployeeId })
                    .HasName("IX_tblPayRollDetail");

                entity.HasIndex(e => new { e.intBenefitTypeId, e.flBenefit, e.intEmployeeId, e.dtMonth, e.dtYear, e.intCompanyId })
                    .HasName("missing_index_4484");

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblPayRollGeneralSetting>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblPayRollTemplate>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPayrollApproval>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPayrollBranchPercentage>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPayrollDeletionLocation>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPayrollEmailSend>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.Property(e => e.intSeqId).ValueGeneratedOnAdd();

                entity.Property(e => e.varEmail).IsUnicode(false);
            });

            modelBuilder.Entity<tblPayrollStructure>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPayrollVerificationFlow>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPerformanceAppraisal>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => e.intCompanyId)
                    .HasName("IX_tblPerformanceAppraisal");
            });

            modelBuilder.Entity<tblPerformanceAppraisalDetailMonth>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblPerformanceAppraisalMailMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intCompanyid })
                    .HasName("PK_tblPerformanceAppraisalMail");

                entity.HasIndex(e => new { e.intClientid, e.intCompanyid, e.intEmployeeid, e.intManageID })
                    .HasName("IX_tblPerformanceAppraisalMailMaster");

                entity.HasIndex(e => new { e.intEmployeeid, e.isstatus, e.intCompanyid, e.varYear })
                    .HasName("missing_index_159");
            });

            modelBuilder.Entity<tblPerformanceAppraisalSaveData>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.issubmit, e.intSetid, e.intSendTo, e.intCompanyId })
                    .HasName("missing_index_825");

                entity.HasIndex(e => new { e.varRating, e.varTiming, e.intManageID, e.intParentId, e.intCompanyId })
                    .HasName("missing_index_504");

                entity.HasIndex(e => new { e.intMasterId, e.intClientid, e.intCompanyId, e.intEmployeeId, e.intManageID, e.intParentId })
                    .HasName("IX_tblPerformanceAppraisalSaveData");

                entity.HasIndex(e => new { e.varRating, e.issubmit, e.dtCreationDate, e.intParentId, e.dtManualCreationDate, e.intCompanyId })
                    .HasName("missing_index_3785");

                entity.HasIndex(e => new { e.varRating, e.issubmit, e.intSetid, e.dtManualCreationDate, e.intParentId, e.intCompanyId })
                    .HasName("missing_index_256");
            });

            modelBuilder.Entity<tblPerformanceApraisalMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblPerformanceTemplateDetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPerformancetemplate>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblPlannerTrainingDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPreQualification>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblPreQu__902531BA18212340");

                entity.Property(e => e.varFocalPerson).IsUnicode(false);
            });

            modelBuilder.Entity<tblPreviousSchoolHistory>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblProductCategory>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblProfit>(entity =>
            {
                entity.Property(e => e.IntSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblProjectAssign>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblProjectDetails>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblProjectSetup>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblProjects>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblPromotion>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblProvidentFund>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intcompanyid });

                entity.HasIndex(e => new { e.intcompanyid, e.intEmployeeid })
                    .HasName("IX_tblProvidentFund");

                entity.Property(e => e.PFPayment).IsUnicode(false);
            });

            modelBuilder.Entity<tblProvidentFund_Adjustment>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intcompanyid });

                entity.Property(e => e.PFPayment).IsUnicode(false);
            });

            modelBuilder.Entity<tblPurchaseAsset>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblPurchaseOrder>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblQuesCategory>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });
            });

            modelBuilder.Entity<tblQuestionnaireDetails>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblQuestionnaireMaster>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblQuotation>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRack>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblReceivedRegisterDetail>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblRecei__902531BADEF39A67");

                entity.Property(e => e.varSenderPlace).IsUnicode(false);
            });

            modelBuilder.Entity<tblReceptionMgmt>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRefundEOBI>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRefundPolicy>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblReibursmentReportLock>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblReligion>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblReportHeadFooter>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblReqTypeDepartment>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRequestManagement>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRequestNotes>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRequestStatusLog>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRequestType>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRequestTypeDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblReservedBookDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID })
                    .HasName("PK_tblReservedDetail");
            });

            modelBuilder.Entity<tblReservedBookMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyId });
            });

            modelBuilder.Entity<tblResignDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblResignEmployee>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblReviewProfile>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblRooms>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblRoster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });

                entity.Property(e => e.intSeqID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblRoutDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblRoutMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblSMSDetails>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSalary>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intMasterId, e.intBranchID, e.flGrossSalary, e.flRate, e.varSalaryType })
                    .HasName("IX_tblSalary");

                entity.HasIndex(e => new { e.intMasterId, e.flSalary, e.isAuto, e.flGrossSalary, e.flDailySalaryPType, e.varSalaryType, e.intCompanyId })
                    .HasName("missing_index_5383");
            });

            modelBuilder.Entity<tblSalaryAdvance>(entity =>
            {
                entity.HasIndex(e => new { e.intEmployeeid, e.intCompanyid })
                    .HasName("IX_tblSalaryAdvance");

                entity.Property(e => e.intSeqid).ValueGeneratedNever();

                entity.Property(e => e.intVMasterId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tblSaveNotificationEmailRecord>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_SaveNotificationEmailRecord");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblScheduleOfWorks>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblSection>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblSecurityRefundable>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSendAbsentEmailRecords>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSendAnalysisWeeklyEmailRecords>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSendDailyAttEmailRecords>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSendLateEmailRecords>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyId, e.intEmployeeId, e.isSendEmail, e.dtDate })
                    .HasName("IX_tblSendLateEmailRecords");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSendMsgToEmployee>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });
            });

            modelBuilder.Entity<tblSession>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblSetting>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.flLateInHours, e.flhours, e.flLateExemption, e.intAttDays })
                    .HasName("IX_tblSetting_1");

                entity.HasIndex(e => new { e.intWeekStartDay, e.dtLoanModuleDate, e.dtPfdate, e.dtTaxDate, e.intNotMonthDays })
                    .HasName("IX_tblSetting");
            });

            modelBuilder.Entity<tblSettingLiveModule>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intCompanyId });
            });

            modelBuilder.Entity<tblSettingOT>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.Property(e => e.intSeqId).IsFixedLength();
            });

            modelBuilder.Entity<tblShelves>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblShiftChild>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblShiftDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblShiftDifference>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblShiftEmployee>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblShiftLog>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblShiftMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblShiftPlaning>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblShortMinSlabs>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblShort__902531BA2BA0EF73");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSignature>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSlotsManagement>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblSocialSecurity>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblSocialSecurityDays>(entity =>
            {
                entity.HasKey(e => e.intSeqID)
                    .HasName("PK_tblSocialSecurityDay_1");

                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSparePart>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSpouseInfo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblState>(entity =>
            {
                entity.HasKey(e => new { e.varCountry, e.varState });
            });

            modelBuilder.Entity<tblStockDetail>(entity =>
            {
                entity.Property(e => e.intSeqid).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblStrengthEmployee>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblStrengthandAreasImprovement>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblStudent>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblStudentAttendance>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblStudentClassSection>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblStudentHealthHabit>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID })
                    .HasName("PK_tblStudentHealth");
            });

            modelBuilder.Entity<tblStudentteacherBusStop>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID })
                    .HasName("PK_tblStudentteacherStop");
            });

            modelBuilder.Entity<tblSubDep>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblSubcompany>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblSubco__902531BA9AC8BCD3");

                entity.Property(e => e.imgLogo).IsUnicode(false);

                entity.Property(e => e.varAbbrevation).IsUnicode(false);

                entity.Property(e => e.varAddress).IsUnicode(false);

                entity.Property(e => e.varEmail).IsUnicode(false);

                entity.Property(e => e.varNtn).IsUnicode(false);

                entity.Property(e => e.varPhone).IsUnicode(false);

                entity.Property(e => e.varSubCompanyName).IsUnicode(false);
            });

            modelBuilder.Entity<tblSubject>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblSupplier>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();

                entity.Property(e => e.varAccountno).IsUnicode(false);

                entity.Property(e => e.varContactNo1).IsFixedLength();

                entity.Property(e => e.varContactNo2).IsFixedLength();

                entity.Property(e => e.varContactPerson1).IsFixedLength();

                entity.Property(e => e.varContactPerson2).IsFixedLength();

                entity.Property(e => e.varDesignation).IsFixedLength();

                entity.Property(e => e.varDesignation1).IsFixedLength();

                entity.Property(e => e.varPaymentTerms).IsFixedLength();
            });

            modelBuilder.Entity<tblSwapRosterShiftLog>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskCat>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTaskChat>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskClient>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskClientDetailEmp>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskComments>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskDateTimeDetail>(entity =>
            {
                entity.HasIndex(e => new { e.intMasterID, e.dtTimeTaskHours, e.dtTimeTaskMint, e.intCompanyID })
                    .HasName("missing_index_25263");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskDetails>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTaskEmailCheck>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskEmp>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTaskLabel>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskMeasurementKPI>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskMgmt>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTaskMgmtMaster>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyId, e.intParentID })
                    .HasName("missing_index_464");

                entity.HasIndex(e => new { e.intEmployeeId, e.dtTaskDate, e.varTaskTitle, e.varTaskDescription, e.Status, e.intCreatedBy, e.isComplete, e.dtTaskComplete, e.intProjectId, e.intCategoryId, e.intClientId, e.intParentID, e.intTaskLabel, e.intCompanyId, e.dtCopmleteDate })
                    .HasName("missing_index_146");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskMgmtSetting>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskModeration>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskProgressDetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblTaskProgressMaster>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskProject>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_TaskMgmt");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskProjectDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaskRating>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaxAdj>(entity =>
            {
                entity.HasIndex(e => new { e.intCompanyId, e.Employee })
                    .HasName("IX_tblTaxAdj");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTaxDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });

                entity.HasIndex(e => new { e.intDepartmentId, e.intMasterTaxID })
                    .HasName("IX_tblTaxDetail");
            });

            modelBuilder.Entity<tblTaxMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => e.intDepId)
                    .HasName("IX_tblTaxMaster");
            });

            modelBuilder.Entity<tblTeacherMgmt>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_tblTeacherInfo");
            });

            modelBuilder.Entity<tblTeacherReferences>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTeacherSubject>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTeamAttendanceRules>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTexPeriod>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTexSlabs>(entity =>
            {
                entity.HasKey(e => new { e.intSeqid, e.intCompanyid });

                entity.Property(e => e.intSeqid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblTicketDetails>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTicketMaster>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTimeSheetDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTimeSheetMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTimeTable>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTitleHelpDesk>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTrainingApprovalFlowSave>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTrainingFlowSetUp>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTransferOrder>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTravel>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTravelESS>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblTravelExpenseDetail>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblTravelExpenseMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblUnit>(entity =>
            {
                entity.HasIndex(e => e.varUnit)
                    .HasName("UK_tblUnit_varUnit")
                    .IsUnique();

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblUnitManagement>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });
            });

            modelBuilder.Entity<tblUniversities>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblUserBranches>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblUserRights>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });

                entity.HasIndex(e => new { e.intUserId, e.intPageId, e.intBranchId, e.isAdd, e.isControl })
                    .HasName("IX_tblUserRights");
            });

            modelBuilder.Entity<tblUserRole>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblUserRoleRights>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblUserType>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblUsers>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId })
                    .HasName("PK_userManagement");

                entity.Property(e => e.isActive).HasDefaultValueSql("('False')");

                entity.Property(e => e.varDashboardGrid).IsUnicode(false);
            });

            modelBuilder.Entity<tblVehicalType>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblVehicaltype");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblVehicleManagement>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblVehic__902531BA899537CA");
            });

            modelBuilder.Entity<tblVehicleSetup>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblVehic__902531BAB5C99633");
            });

            modelBuilder.Entity<tblVendorProduct>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK_tblVendorProducts_1");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblVendorProductsDetail>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblVersion>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblWarehouseManagement>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<tblWebAdminSettings>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });
            });

            modelBuilder.Entity<tblWishes>(entity =>
            {
                entity.HasKey(e => e.intSeqId)
                    .HasName("PK__tblWishe__902531BAAD55745D");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblWorkingDays>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });

                entity.HasIndex(e => new { e.intCompanyID, e.intEmployeeId })
                    .HasName("IX_tblWorkingDays");

                entity.HasIndex(e => new { e.intBranchID, e.intEmployeeId, e.intDepartmentID })
                    .HasName("IX_tblWorkingDays_1");

                entity.Property(e => e.intSeqID).ValueGeneratedOnAdd();

                entity.Property(e => e.dtFriBmin).IsUnicode(false);

                entity.Property(e => e.dtFriShiftAbb).IsUnicode(false);

                entity.Property(e => e.dtMonBmin).IsUnicode(false);

                entity.Property(e => e.dtMonShiftAbb).IsUnicode(false);

                entity.Property(e => e.dtSatBmin).IsUnicode(false);

                entity.Property(e => e.dtSatShiftAbb).IsUnicode(false);

                entity.Property(e => e.dtSunBmin).IsUnicode(false);

                entity.Property(e => e.dtSunShiftAbb).IsUnicode(false);

                entity.Property(e => e.dtThursBmin).IsUnicode(false);

                entity.Property(e => e.dtThursShiftAbb).IsUnicode(false);

                entity.Property(e => e.dtTuesBmin).IsUnicode(false);

                entity.Property(e => e.dtTuesShiftAbb).IsUnicode(false);

                entity.Property(e => e.dtWedBmin).IsUnicode(false);

                entity.Property(e => e.dtWedShiftAbb).IsUnicode(false);

                entity.Property(e => e.flFriExeTitle).IsUnicode(false);

                entity.Property(e => e.flMonExeTitle).IsUnicode(false);

                entity.Property(e => e.flSatExeTitle).IsUnicode(false);

                entity.Property(e => e.flSunExeTitle).IsUnicode(false);

                entity.Property(e => e.flThuExeTitle).IsUnicode(false);

                entity.Property(e => e.flTueExeTitle).IsUnicode(false);

                entity.Property(e => e.flWedExeTitle).IsUnicode(false);
            });

            modelBuilder.Entity<tblWorkingDaysSlabs>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.varFromWorkingDay, e.varWorkingDayMint, e.intCompanyid, e.intDepartmentId, e.intBranchId, e.varToWorkingDay })
                    .HasName("missing_index_1963");
            });

            modelBuilder.Entity<tblbloodgroup>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tbldashboardComment>(entity =>
            {
                entity.HasIndex(e => new { e.intEmployeeId, e.intCompanyId, e.dtDateComment })
                    .HasName("IX_tbldashboardComment");

                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblprovidentfunds>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyID });

                entity.HasIndex(e => e.intCompanyID)
                    .HasName("IX_tblprovidentfunds");
            });

            modelBuilder.Entity<tblpublicHolidayMaster>(entity =>
            {
                entity.HasKey(e => new { e.intSeqID, e.intCompanyID });

                entity.Property(e => e.varAbbrivation)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<tblpublicholidaychild>(entity =>
            {
                entity.HasKey(e => new { e.intSeqId, e.intCompanyId });
            });

            modelBuilder.Entity<tblstockMaster>(entity =>
            {
                entity.Property(e => e.intSeqID).ValueGeneratedNever();
            });

            modelBuilder.Entity<tbltagbranch>(entity =>
            {
                entity.Property(e => e.intSeqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<tbltopoffendsvalue>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<viewStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStock");

                entity.Property(e => e.abc).IsUnicode(false);
            });

            modelBuilder.Entity<vwEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmployee");

                entity.Property(e => e.intShiftID).IsUnicode(false);

                entity.Property(e => e.varAddress1).IsUnicode(false);

                entity.Property(e => e.varAddress2).IsUnicode(false);

                entity.Property(e => e.varBankAc).IsUnicode(false);

                entity.Property(e => e.varCNIC).IsUnicode(false);

                entity.Property(e => e.varDependent).IsUnicode(false);

                entity.Property(e => e.varDrivingLiscNo).IsUnicode(false);

                entity.Property(e => e.varEOBINo).IsUnicode(false);

                entity.Property(e => e.varEmail).IsUnicode(false);

                entity.Property(e => e.varEmailPvt).IsUnicode(false);

                entity.Property(e => e.varExperience).IsUnicode(false);

                entity.Property(e => e.varFamily).IsUnicode(false);

                entity.Property(e => e.varFatherCNIC).IsUnicode(false);

                entity.Property(e => e.varFatherName).IsUnicode(false);

                entity.Property(e => e.varGrade).IsUnicode(false);

                entity.Property(e => e.varImagePath).IsUnicode(false);

                entity.Property(e => e.varInsurance).IsUnicode(false);

                entity.Property(e => e.varLivingWith).IsUnicode(false);

                entity.Property(e => e.varMarkOfIdentity).IsUnicode(false);

                entity.Property(e => e.varMarriageNo).IsUnicode(false);

                entity.Property(e => e.varMarriageWith).IsUnicode(false);

                entity.Property(e => e.varNTN).IsUnicode(false);

                entity.Property(e => e.varOthers).IsUnicode(false);

                entity.Property(e => e.varPermPhone).IsUnicode(false);

                entity.Property(e => e.varPhone).IsUnicode(false);

                entity.Property(e => e.varSex).IsUnicode(false);

                entity.Property(e => e.varSocialSecurityNo).IsUnicode(false);

                entity.Property(e => e.varSuitable).IsUnicode(false);
            });

            modelBuilder.Entity<vwGetEmployees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetEmployees");
            });

            modelBuilder.Entity<vwGetLeavesDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetLeavesDetail");
            });

            modelBuilder.Entity<wvEmployeeNewView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wvEmployeeNewView");

                entity.Property(e => e.intShiftID).IsUnicode(false);

                entity.Property(e => e.varAddress1).IsUnicode(false);

                entity.Property(e => e.varAddress2).IsUnicode(false);

                entity.Property(e => e.varBankAc).IsUnicode(false);

                entity.Property(e => e.varCNIC).IsUnicode(false);

                entity.Property(e => e.varDependent).IsUnicode(false);

                entity.Property(e => e.varDrivingLiscNo).IsUnicode(false);

                entity.Property(e => e.varEOBINo).IsUnicode(false);

                entity.Property(e => e.varEmail).IsUnicode(false);

                entity.Property(e => e.varEmailPvt).IsUnicode(false);

                entity.Property(e => e.varExperience).IsUnicode(false);

                entity.Property(e => e.varFamily).IsUnicode(false);

                entity.Property(e => e.varFatherCNIC).IsUnicode(false);

                entity.Property(e => e.varFatherName).IsUnicode(false);

                entity.Property(e => e.varFirstName).IsUnicode(false);

                entity.Property(e => e.varGrade).IsUnicode(false);

                entity.Property(e => e.varImagePath).IsUnicode(false);

                entity.Property(e => e.varInsurance).IsUnicode(false);

                entity.Property(e => e.varLastName).IsUnicode(false);

                entity.Property(e => e.varLivingWith).IsUnicode(false);

                entity.Property(e => e.varMarkOfIdentity).IsUnicode(false);

                entity.Property(e => e.varMarriageNo).IsUnicode(false);

                entity.Property(e => e.varMarriageWith).IsUnicode(false);

                entity.Property(e => e.varNTN).IsUnicode(false);

                entity.Property(e => e.varOthers).IsUnicode(false);

                entity.Property(e => e.varPermPhone).IsUnicode(false);

                entity.Property(e => e.varPhone).IsUnicode(false);

                entity.Property(e => e.varSex).IsUnicode(false);

                entity.Property(e => e.varSocialSecurityNo).IsUnicode(false);

                entity.Property(e => e.varSuitable).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
