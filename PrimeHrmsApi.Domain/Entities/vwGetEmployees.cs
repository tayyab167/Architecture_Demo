using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class vwGetEmployees
    {
        public int intSeqId { get; set; }
        public int? intWorkingHour { get; set; }
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
        public int? intShiftID { get; set; }
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
        public double totIncentive { get; set; }
        public double totDeduction { get; set; }
        public double? flSalary { get; set; }
    }
}
