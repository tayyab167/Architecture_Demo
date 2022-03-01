using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCareerPathDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [StringLength(50)]
        public string varName { get; set; }
        public int? intLevel { get; set; }
        [StringLength(4000)]
        public string varDescription { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
    }
}
