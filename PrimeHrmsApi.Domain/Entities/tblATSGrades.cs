using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblATSGrades
    {
        public int? intSeqId { get; set; }
        [StringLength(50)]
        public string varGradeName { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public double? flSalaryFrom { get; set; }
        public double? flWSalaryTo { get; set; }
        public double? flExperienceFrom { get; set; }
        public double? flExperienceTo { get; set; }
        public int? intFromAge { get; set; }
        public int? intToAge { get; set; }
        [StringLength(150)]
        public string varQualification { get; set; }
    }
}
