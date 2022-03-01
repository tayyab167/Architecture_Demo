using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDesignation
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varName { get; set; }
        [StringLength(200)]
        public string varDescription { get; set; }
        [StringLength(100)]
        public string varGrade { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [StringLength(500)]
        public string varJobDescription { get; set; }
        [StringLength(10)]
        public string varAbbri { get; set; }
        public double? flMedicalLimit { get; set; }
        [StringLength(500)]
        public string varOtherDesignationName { get; set; }
    }
}
