using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpFamilyInfo
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varDependent { get; set; }
        [StringLength(100)]
        public string varMarriageWith { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMarriageDate { get; set; }
        [StringLength(100)]
        public string varMarriageNo { get; set; }
        [StringLength(100)]
        public string varChild1 { get; set; }
        [StringLength(100)]
        public string varGender1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDOB1 { get; set; }
        [StringLength(100)]
        public string varCNIC1 { get; set; }
        [StringLength(100)]
        public string varChild2 { get; set; }
        [StringLength(100)]
        public string varGender2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDOB2 { get; set; }
        [StringLength(100)]
        public string varCNIC2 { get; set; }
        [StringLength(100)]
        public string varChild3 { get; set; }
        [StringLength(100)]
        public string varGender3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDOB3 { get; set; }
        [StringLength(100)]
        public string varCNIC3 { get; set; }
        [StringLength(10)]
        public string intEmployeeId { get; set; }
        [Key]
        public int intComanyID { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
