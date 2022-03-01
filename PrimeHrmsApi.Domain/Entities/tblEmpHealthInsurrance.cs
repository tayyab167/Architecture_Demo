using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpHealthInsurrance
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        [StringLength(100)]
        public string varCNIC { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDOB { get; set; }
        [StringLength(100)]
        public string varPlanHealth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? varEffectiveDate { get; set; }
        [StringLength(100)]
        public string varFullName { get; set; }
        [StringLength(100)]
        public string varRelationship { get; set; }
        [StringLength(100)]
        public string varMaritalstatus { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(50)]
        public string varHealthType { get; set; }
        [StringLength(200)]
        public string varRemarks { get; set; }
        [StringLength(50)]
        public string varGenderHealth { get; set; }
    }
}
