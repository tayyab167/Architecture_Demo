using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblShortMinSlabs
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varShortMinName { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varFromShortMin { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varToShortMin { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varAllocatedShortMin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCompanyid { get; set; }
        public int? intDepartmentId { get; set; }
    }
}
