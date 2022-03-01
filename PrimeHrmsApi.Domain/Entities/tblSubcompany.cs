using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSubcompany
    {
        [Key]
        public int intSeqId { get; set; }
        [Required]
        [StringLength(250)]
        public string varSubCompanyName { get; set; }
        [StringLength(250)]
        public string varEmail { get; set; }
        [StringLength(500)]
        public string varAddress { get; set; }
        [StringLength(50)]
        public string varPhone { get; set; }
        [Required]
        [StringLength(50)]
        public string varAbbrevation { get; set; }
        [StringLength(50)]
        public string varNtn { get; set; }
        [StringLength(500)]
        public string imgLogo { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
    }
}
