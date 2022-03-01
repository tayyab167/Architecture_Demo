using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDemotion
    {
        public int? intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDesignationId { get; set; }
        public int? intParentDeparmentId { get; set; }
        public int? intSubDepartmentId { get; set; }
        public int? intBranchId { get; set; }
        public int? intShiftId { get; set; }
        public double? flSalary { get; set; }
        public double? flOtherAllownces { get; set; }
        public int? intAttendenceCheckHR { get; set; }
        public int? intDisciplineCheckHR { get; set; }
        public int? intDisciplineCheckManager { get; set; }
        public int? intBehaviourCheckManager { get; set; }
        public int? intPerformanceCheckManager { get; set; }
        [StringLength(100)]
        public string varWEF { get; set; }
        public bool? isApproved { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreatedDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intPrevDesignation { get; set; }
        public int? intPrevParentDepartmentId { get; set; }
        public int? intPrevSubDepartment { get; set; }
        public int? intPrevBranchId { get; set; }
        public int? intPrevShiftId { get; set; }
        public double? flPrevSalary { get; set; }
        public double? flPrevOtherAllowences { get; set; }
    }
}
