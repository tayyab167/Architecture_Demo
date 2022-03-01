using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeResignFlow
    {
        public int? intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(50)]
        public string varLoanType { get; set; }
        public int? intId { get; set; }
        public bool? isActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intCompanyId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intBranchId { get; set; }
        public int? intDesignation { get; set; }
    }
}
