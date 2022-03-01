using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPurchaseOrder
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intItemId { get; set; }
        public int? intSupplierId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flQty { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flApprQty { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPrice { get; set; }
        public int? intLocId { get; set; }
        [StringLength(200)]
        public string varDesc { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        public int? intCreatedby { get; set; }
        public int? intUpdatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int intCompanyId { get; set; }
    }
}
