using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLoan
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intLoanId { get; set; }
        public int? intLoanEmpId { get; set; }
        public int? intEmpId { get; set; }
        [StringLength(50)]
        public string VarEmployeeType { get; set; }
        public int? intGuranterId { get; set; }
        [StringLength(300)]
        public string varLoanPurpose { get; set; }
        [StringLength(50)]
        public string intLoanAmount { get; set; }
        [StringLength(50)]
        public string intMonthlyInstalment { get; set; }
        [StringLength(50)]
        public string varDuration { get; set; }
        [StringLength(500)]
        public string varRemarks { get; set; }
        [StringLength(500)]
        public string varReason { get; set; }
        [StringLength(100)]
        public string varStatus { get; set; }
        public bool? isRecomended { get; set; }
        public bool? isApproved { get; set; }
        public int? intCompanyId { get; set; }
        public bool? IsGrossSalary { get; set; }
        public bool? isEntitlement { get; set; }
        public bool? isJobStatus { get; set; }
        public bool? isLastLoanClearence { get; set; }
        [StringLength(50)]
        public string intOutStandingAmount { get; set; }
        public bool? isPreviousLoanPaid { get; set; }
        public bool? isPreviousLoanCheck { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreatedDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        [StringLength(50)]
        public string dtIssueDate { get; set; }
        public bool? isLoanRefunded { get; set; }
        [StringLength(50)]
        public string varRefundDate { get; set; }
        public bool? isChanged { get; set; }
        public bool? isEmailNotify { get; set; }
    }
}
