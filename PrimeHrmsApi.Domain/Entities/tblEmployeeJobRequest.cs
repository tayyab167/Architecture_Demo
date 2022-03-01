using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeJobRequest
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        [StringLength(50)]
        public string varJobTitle { get; set; }
        public int? intJobType { get; set; }
        public int? intNoOfPositions { get; set; }
        public int? intAgeStart { get; set; }
        public int? intAgeEnd { get; set; }
        public double? floatSalaryStart { get; set; }
        public double? floatSalaryEnd { get; set; }
        public string varQualification { get; set; }
        public int? intCompanyId { get; set; }
        public bool? isApproved { get; set; }
        public int? intBranchId { get; set; }
        [StringLength(50)]
        public string varShiftTime { get; set; }
        [Column(TypeName = "text")]
        public string varExperience { get; set; }
        public int? intIndustryTypeID { get; set; }
        [StringLength(50)]
        public string varSex { get; set; }
        public double? flExperienceFrom { get; set; }
        public double? flExperienceTo { get; set; }
        public int? intGradeId { get; set; }
        public string varSkills { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [StringLength(50)]
        public string varJobType { get; set; }
    }
}
