using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeOnBoarding
    {
        [Key]
        public int intSeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string varEmpName { get; set; }
        [Column(TypeName = "date")]
        public DateTime joiningDate { get; set; }
        [Required]
        [StringLength(50)]
        public string varEmail { get; set; }
        public int intDepartmentId { get; set; }
        public int intBranchId { get; set; }
        public int intDesignationId { get; set; }
        public int intEmployeeType { get; set; }
        public int intCompanyId { get; set; }
        [Required]
        [StringLength(50)]
        public string linkKey { get; set; }
        public int overallS { get; set; }
        [StringLength(300)]
        public string varJobDescriptionPath { get; set; }
        public bool? isAgreed { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        public int? intCandidateID { get; set; }
        public int? intAgreementIdNDA { get; set; }
        public int? intAgreementIdContract { get; set; }
    }
}
