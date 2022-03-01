using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblNews
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varNewsHead { get; set; }
        [StringLength(500)]
        public string varNewsDetail { get; set; }
        public int? intBranchID { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
    }
}
