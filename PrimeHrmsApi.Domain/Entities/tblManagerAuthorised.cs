using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblManagerAuthorised
    {
        [Key]
        public int intSeqId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [StringLength(50)]
        public string varName { get; set; }
        [StringLength(50)]
        public string varFname { get; set; }
        [StringLength(100)]
        public string varAddress1 { get; set; }
        [StringLength(50)]
        public string varMobile1 { get; set; }
        [StringLength(50)]
        public string varPhone1 { get; set; }
        [StringLength(100)]
        public string varAddress2 { get; set; }
        [StringLength(50)]
        public string varMobile2 { get; set; }
        [StringLength(50)]
        public string varPhone2 { get; set; }
        [StringLength(100)]
        public string varAddress3 { get; set; }
        [StringLength(50)]
        public string varMobile3 { get; set; }
        [StringLength(50)]
        public string varPhone3 { get; set; }
        [StringLength(50)]
        public string varCity { get; set; }
        [StringLength(500)]
        public string varNotes { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public bool? isActive { get; set; }
        public bool? isDefault { get; set; }
        [StringLength(100)]
        public string varUserName { get; set; }
        [StringLength(50)]
        public string varPassword { get; set; }
        public int? intUserId { get; set; }
    }
}
