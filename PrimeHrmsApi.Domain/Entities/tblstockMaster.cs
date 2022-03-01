using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblstockMaster
    {
        [Key]
        public int intSeqID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtVoucherDate { get; set; }
        [StringLength(500)]
        public string varVoucher { get; set; }
        public int? intVendor { get; set; }
        [StringLength(100)]
        public string varRef { get; set; }
        [StringLength(500)]
        public string varRemarks { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public bool? isvisible { get; set; }
        public int? intLocationId { get; set; }
        [StringLength(100)]
        public string varType { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? flQty { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? flPrice { get; set; }
        public int? intItemId { get; set; }
        public int? intIssueSeqId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intTotalDiscount { get; set; }
        public int? intVMasterId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flGrossAmount { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flAdjustment { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flFreight { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flTax { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flNetAmount { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string varDonorProvided { get; set; }
        [StringLength(50)]
        public string varQuotationforUI { get; set; }
        [StringLength(50)]
        public string varOfficeForGI { get; set; }
    }
}
