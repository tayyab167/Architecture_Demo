using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblBenefit
    {
        [Key]
        public int intSeqID { get; set; }
        [StringLength(100)]
        public string varName { get; set; }
        [StringLength(100)]
        public string varDescription { get; set; }
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        [StringLength(50)]
        public string varAbbri { get; set; }
        public bool? isActive { get; set; }
        public bool? isTaxable { get; set; }
    }
}
