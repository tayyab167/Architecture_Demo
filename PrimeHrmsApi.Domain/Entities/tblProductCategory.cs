using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblProductCategory
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        [StringLength(50)]
        public string varAbbreviation { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [StringLength(50)]
        public string intBranchID { get; set; }
        public int? intCreationBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
    }
}
