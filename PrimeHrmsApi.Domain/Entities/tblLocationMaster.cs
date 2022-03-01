using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLocationMaster
    {
        [Key]
        public int intSeqID { get; set; }
        [StringLength(200)]
        public string varAbbrevation { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intBranchID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdateBy { get; set; }
    }
}
