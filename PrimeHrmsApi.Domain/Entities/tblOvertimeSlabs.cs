using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOvertimeSlabs
    {
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varOvertimeName { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varFromOverTime { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varToOverTime { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? varOverTimeMint { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCompanyid { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intBranchId { get; set; }
    }
}
