using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblMainContactPerson
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varperson1Name { get; set; }
        [StringLength(100)]
        public string varperson1Email { get; set; }
        [StringLength(100)]
        public string varperson1Phone { get; set; }
        [StringLength(500)]
        public string varPerson1Address { get; set; }
        [StringLength(200)]
        public string varperson2Name { get; set; }
        [StringLength(100)]
        public string varperson2Email { get; set; }
        [StringLength(100)]
        public string varperson2Phone { get; set; }
        [StringLength(500)]
        public string varPerson2Address { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
