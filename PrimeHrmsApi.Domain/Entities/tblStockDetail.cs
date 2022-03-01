using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblStockDetail
    {
        [Key]
        public int intSeqid { get; set; }
        public int? intVoucherID { get; set; }
        [StringLength(500)]
        public string varItemCode { get; set; }
        [StringLength(500)]
        public string varItemName { get; set; }
        public int? intUnitId { get; set; }
        [StringLength(500)]
        public string varUnit { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? flOldCost { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? flPrice { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? flQty { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? flRecQty { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? flLineCost { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? flNewCost { get; set; }
        public int? intComUnitId { get; set; }
        public double? flUnitConvert { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dtUpdateDate { get; set; }
        [StringLength(100)]
        public string varType { get; set; }
        [StringLength(200)]
        public string varDescription { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? GRNQty { get; set; }
        public bool? isPromotion { get; set; }
        public double? flDiscount { get; set; }
        public int? intCompanyId { get; set; }
        public bool? isIssue { get; set; }
        public int? intOrderId { get; set; }
    }
}
