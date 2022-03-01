using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaxMaster
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intDepId { get; set; }
        [StringLength(100)]
        public string varTaxName { get; set; }
        public double? flRate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedate { get; set; }
    }
}
