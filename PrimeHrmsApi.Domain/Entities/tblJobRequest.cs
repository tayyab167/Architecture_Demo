using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblJobRequest
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmpId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intDepId { get; set; }
        [StringLength(50)]
        public string varJobTitle { get; set; }
        public int? intJobType { get; set; }
        public int? intPosition { get; set; }
        public int? StartAge { get; set; }
        public int? EndAge { get; set; }
        public double? flStartSalary { get; set; }
        public double? flEndSalary { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(3000)]
        public string varDescription { get; set; }
        public bool? isApproved { get; set; }
        public int? intIndustryTypeID { get; set; }
        public string varExperience { get; set; }
        [StringLength(50)]
        public string varShiftTime { get; set; }
        public int? intBranchId { get; set; }
        [StringLength(50)]
        public string varSex { get; set; }
    }
}
