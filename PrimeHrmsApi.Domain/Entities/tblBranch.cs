using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblBranch
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(300)]
        public string varBranchName { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
        public string varImagePath { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(500)]
        public string varAddress { get; set; }
        public double? flLongitude { get; set; }
        public double? flLatitude { get; set; }
        [StringLength(50)]
        public string BranchCity { get; set; }
        public int? intMasterBranch { get; set; }
        public int? intLimitEmployees { get; set; }
        public bool? isBranchWiseDetailInPayslip { get; set; }
        [Column(TypeName = "image")]
        public byte[] varBranchLogoHexa { get; set; }
        public int? intPreparedBy { get; set; }
        public int? intVerifiedBy { get; set; }
        public bool? isAllowVerify { get; set; }
        public int? intApprovedBy { get; set; }
        public int? intHeadBranch { get; set; }
        public int? intPrevDays { get; set; }
        public int? intNextdays { get; set; }
        public double? flradius { get; set; }
        [StringLength(50)]
        public string RegistrationNumber { get; set; }
        public bool? isOnlyShiftTimeOverTime { get; set; }
        public bool? isRewardInPayroll { get; set; }
        [StringLength(2)]
        public string varRewardDays { get; set; }
        [StringLength(1050)]
        public string varMonthDaysInPayroll { get; set; }
        public double? flFixedDays { get; set; }
        public int? intBillReimbursLimit { get; set; }
        public int? intPrevDaysAtt { get; set; }
        public int? intNextDaysAtt { get; set; }
    }
}
