using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblItem
    {
        [Key]
        public int intItemId { get; set; }
        [StringLength(50)]
        public string varItemCode { get; set; }
        [StringLength(50)]
        public string varItemName { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flSellingPrice { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPurchasePrice { get; set; }
        public int? intPurchaseItemUnit { get; set; }
        public int? intSellingItemUnit { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? flLiter { get; set; }
        public bool? isShowSellingUnitQty { get; set; }
        public int? intConvertUnit { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intOpeningQty { get; set; }
        public int? flPackingSize { get; set; }
        public int? intCategoryId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flCurrentStock { get; set; }
        public int? intWareHouse { get; set; }
        [StringLength(50)]
        public string varBin { get; set; }
        [StringLength(50)]
        public string varShelve { get; set; }
        [StringLength(50)]
        public string strIngredient { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intCreationBy { get; set; }
        public int? intUpdatedBy { get; set; }
        public bool? istax { get; set; }
        [StringLength(50)]
        public string varSKUcode { get; set; }
        public bool? isConsumed { get; set; }
        public int? intLife { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtExpiryDate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flPick { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flTana { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flBana { get; set; }
        public double? flArz { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flRead { get; set; }
        [StringLength(250)]
        public string varName { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? intSaleAccID { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? intPurchaseAccID { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        public int? intBranchID { get; set; }
        [StringLength(2000)]
        public string oleImage { get; set; }
    }
}
