using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAdminDocument
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varReference { get; set; }
        [StringLength(500)]
        public string varSubject { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [StringLength(500)]
        public string varFrom { get; set; }
        [StringLength(500)]
        public string varTo { get; set; }
        [StringLength(1000)]
        public string varTag { get; set; }
        public int? intTypeId { get; set; }
        public int? intCreatedBy { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(100)]
        public string varFilePath1 { get; set; }
        [StringLength(100)]
        public string varFilePath2 { get; set; }
        [StringLength(100)]
        public string varFilePath3 { get; set; }
        [StringLength(50)]
        public string varResponse { get; set; }
        public int? intDocumentTypeId { get; set; }
    }
}
