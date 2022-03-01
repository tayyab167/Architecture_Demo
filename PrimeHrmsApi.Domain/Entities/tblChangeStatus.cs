using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblChangeStatus
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intDepartmentIdOld { get; set; }
        public int? intDesignationId { get; set; }
        public int? intDesignationIdOld { get; set; }
        public int? intBranchId { get; set; }
        public int? intBranchIdOld { get; set; }
        public int? intEmployeeType { get; set; }
        public int? intEmpTypeOld { get; set; }
        public int? intReportedTo { get; set; }
        public int? intReportedToOld { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flSalary { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flSalaryOld { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtChangeDepartment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtChangeDesignatin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtChangeBranch { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtChangeEmptype { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtChangeReportedTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtChangeSalary { get; set; }
        [StringLength(200)]
        public string varRemarksStatus { get; set; }
        public int? intIncreamentStatus { get; set; }
        [StringLength(200)]
        public string varIncreamentAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEffectiveDate { get; set; }
        public int? intParentDepartmentIdOld { get; set; }
        public int? intPMSDateWiseIncrement { get; set; }
    }
}
