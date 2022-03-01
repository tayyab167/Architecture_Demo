using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeComplains
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intComplainType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtComplainDate { get; set; }
        [StringLength(500)]
        public string varComplainDescription { get; set; }
        [StringLength(200)]
        public string intAgainstEmployee { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intEmpID { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        [StringLength(500)]
        public string varRemarks { get; set; }
        [StringLength(500)]
        public string varAttachmentFile { get; set; }
        [StringLength(1050)]
        public string varSummary { get; set; }
        [StringLength(1050)]
        public string varDecision { get; set; }
        [StringLength(1050)]
        public string varCaseDetails { get; set; }
    }
}
