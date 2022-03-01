using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPayrollApproval
    {
        public int? intSeqId { get; set; }
        public int? intComapnyId { get; set; }
        [StringLength(150)]
        public string varFormula { get; set; }
        [StringLength(150)]
        public string varReportPath { get; set; }
        [StringLength(150)]
        public string varReportName { get; set; }
        [StringLength(50)]
        public string varmonth { get; set; }
        [StringLength(50)]
        public string varyear { get; set; }
        [StringLength(50)]
        public string varFromDate { get; set; }
        [StringLength(50)]
        public string varToDate { get; set; }
        [StringLength(50)]
        public string vardepartment { get; set; }
        [StringLength(250)]
        public string varEmployee { get; set; }
        [StringLength(50)]
        public string varbranch { get; set; }
        [StringLength(50)]
        public string varpayrollType { get; set; }
        [StringLength(50)]
        public string varAuthority { get; set; }
        [StringLength(100)]
        public string varName { get; set; }
        [StringLength(100)]
        public string varEmail { get; set; }
        public bool? isApproveReject { get; set; }
        [StringLength(450)]
        public string varRemarks { get; set; }
        public int? intPayrollId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovalDate { get; set; }
    }
}
