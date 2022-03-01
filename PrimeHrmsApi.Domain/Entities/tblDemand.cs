using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDemand
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intItemId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flQty { get; set; }
        public int? intDepId { get; set; }
        [StringLength(500)]
        public string varRemarks { get; set; }
        [StringLength(100)]
        public string varStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdatedby { get; set; }
        public int? intCompanyId { get; set; }
        public bool? isApprove { get; set; }
        public int? intAppRejBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAppRejDate { get; set; }
        [StringLength(4000)]
        public string varAppRejDetails { get; set; }
    }
}
