using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTeacherMgmt
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(1000)]
        public string varFirstName { get; set; }
        [StringLength(1000)]
        public string varLastName { get; set; }
        [StringLength(50)]
        public string varExperience { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtJoiningDate { get; set; }
        [StringLength(1000)]
        public string varDesignation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDateOfBirth { get; set; }
        [StringLength(100)]
        public string varSalary { get; set; }
        [StringLength(50)]
        public string varPhone { get; set; }
        [StringLength(50)]
        public string varEmail { get; set; }
        [StringLength(2000)]
        public string varAddress1 { get; set; }
        [StringLength(2000)]
        public string varAddress2 { get; set; }
        [StringLength(1500)]
        public string varOthers { get; set; }
        [StringLength(300)]
        public string varImagePath { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
