using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblBenefitMaster
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public double? flAmount { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intBranchId { get; set; }
        [StringLength(50)]
        public string varCategory { get; set; }
        [StringLength(50)]
        public string varBenefitType { get; set; }
        public int? intBenefitId { get; set; }
        [StringLength(50)]
        public string varNumberOfMonths { get; set; }
        [StringLength(200)]
        public string varPath { get; set; }
    }
}
