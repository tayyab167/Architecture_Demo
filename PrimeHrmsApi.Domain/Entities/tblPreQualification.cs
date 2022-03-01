using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPreQualification
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varCompanyName { get; set; }
        public int? intCompanyType { get; set; }
        [StringLength(50)]
        public string varFocalPerson { get; set; }
        [StringLength(30)]
        public string varContactNumber { get; set; }
        [StringLength(200)]
        public string varCompanyWorkArea { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
    }
}
