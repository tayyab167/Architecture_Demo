using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeLoanMaster
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLoanDate { get; set; }
        public double? flAmount { get; set; }
        public double? flDeduction { get; set; }
        public int? intLoanMonth { get; set; }
        public int? intLoanYear { get; set; }
        public int? intStartMonth { get; set; }
        public int? intStartYear { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLoanStartDate { get; set; }
        public int? intNoOfMonths { get; set; }
        public bool? isApproved { get; set; }
        public int? intApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovalDate { get; set; }
        [StringLength(500)]
        public string varApprovalDescription { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public bool? isFreeze { get; set; }
        public int? intGuaranteeEmpName { get; set; }
        public int? intTotalMonthFreeze { get; set; }
        public int? intTotalInstall { get; set; }
        public bool? isMergeValue { get; set; }
        public int? varAdjustmentValue { get; set; }
        public int? intGuaranteeSecondEmp { get; set; }
        public int? MergedLoanWith { get; set; }
        public double? flPreviousBalance { get; set; }
        public bool? isMergeLoan { get; set; }
        [StringLength(50)]
        public string varLoanCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFreezeDate { get; set; }
    }
}
