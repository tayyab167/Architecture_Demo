using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpExperience
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToDate { get; set; }
        [StringLength(200)]
        public string varDesignation { get; set; }
        [StringLength(300)]
        public string varCompany { get; set; }
        [StringLength(200)]
        public string varEmployer { get; set; }
        [StringLength(200)]
        public string varContactPerson { get; set; }
        public string varResponsibilities { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
