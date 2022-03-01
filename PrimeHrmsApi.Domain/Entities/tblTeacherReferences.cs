using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTeacherReferences
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [StringLength(100)]
        public string varFirstName { get; set; }
        [StringLength(100)]
        public string varLastName { get; set; }
        [StringLength(1000)]
        public string varWork { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDateOfBirth { get; set; }
        [StringLength(100)]
        public string varRelation { get; set; }
        [StringLength(50)]
        public string varEmail { get; set; }
        [StringLength(50)]
        public string varPhone { get; set; }
        [StringLength(500)]
        public string varAddress { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
