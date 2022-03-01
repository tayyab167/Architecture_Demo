using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAdminUsers
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varName { get; set; }
        [StringLength(200)]
        public string varEmail { get; set; }
        [StringLength(50)]
        public string varPhone { get; set; }
        [StringLength(500)]
        public string varUserName { get; set; }
        [StringLength(2000)]
        public string varPassword { get; set; }
        public bool? isActive { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
