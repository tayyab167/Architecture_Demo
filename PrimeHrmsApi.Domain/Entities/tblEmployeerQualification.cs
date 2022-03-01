using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeerQualification
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [StringLength(1000)]
        public string varDegree { get; set; }
        [StringLength(1000)]
        public string varBoard { get; set; }
        public int? intDegreeId { get; set; }
        public int? intPassingYear { get; set; }
        [StringLength(200)]
        public string varSubject { get; set; }
        [StringLength(200)]
        public string varRate { get; set; }
        [StringLength(50)]
        public string varGrade { get; set; }
        public double? flCgpa { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intBranchID { get; set; }
        [StringLength(500)]
        public string varFilePath { get; set; }
        public bool? isESS { get; set; }
    }
}
