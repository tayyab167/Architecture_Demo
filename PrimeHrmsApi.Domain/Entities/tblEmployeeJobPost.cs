using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeJobPost
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(150)]
        public string varJobTitle { get; set; }
        public int? intJobType { get; set; }
        public int? intBranchId { get; set; }
        public int? intDepartmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime varClosingDate { get; set; }
        public int? intNoOfPosition { get; set; }
        [StringLength(50)]
        public string isPublishInPortal { get; set; }
        public int? intAgeRangeStart { get; set; }
        public int? intAgeRangeEnd { get; set; }
        public int? intSalaryRangeStart { get; set; }
        public int? intSalaryRangeEnd { get; set; }
        public string varQualification { get; set; }
        [Column(TypeName = "text")]
        public string varExperience { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string varSex { get; set; }
        public int? intIndustryTypeID { get; set; }
        [StringLength(50)]
        public string varShiftTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dtCreationDate { get; set; }
        [StringLength(1500)]
        public string varJobSkills { get; set; }
        public int? intClientId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPublishDate { get; set; }
        public double? flExperienceFrom { get; set; }
        public double? flExperienceTo { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(150)]
        public string varJobNo { get; set; }
    }
}
