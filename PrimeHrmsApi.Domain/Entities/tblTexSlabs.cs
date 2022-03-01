using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTexSlabs
    {
        [Key]
        public int intSeqid { get; set; }
        [StringLength(200)]
        public string varSlabName { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varFromSalary { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varToSalary { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varPercenat { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flOtherTax { get; set; }
        public bool? isActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Key]
        public int intCompanyid { get; set; }
        public bool? isTaxSlabAccording { get; set; }
    }
}
