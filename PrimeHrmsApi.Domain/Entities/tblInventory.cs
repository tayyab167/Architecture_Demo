using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblInventory
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string intItemCode { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        [StringLength(50)]
        public string varName { get; set; }
        [StringLength(50)]
        public string varUPCcode { get; set; }
        public int? intInventCatId { get; set; }
        public bool? isTax { get; set; }
        [StringLength(50)]
        public string intStatus { get; set; }
        [StringLength(50)]
        public string varInvenType { get; set; }
        [StringLength(50)]
        public string varQuantity { get; set; }
        public bool? isSellable { get; set; }
        public bool? isDiscount { get; set; }
        [StringLength(50)]
        public string varSupplier { get; set; }
        public int? intLocationId { get; set; }
        [StringLength(50)]
        public string varOrderLevel { get; set; }
        [StringLength(50)]
        public string varCost { get; set; }
        [StringLength(50)]
        public string varPSprice { get; set; }
        [StringLength(50)]
        public string varMarginRs { get; set; }
        [StringLength(50)]
        public string varmarginPer { get; set; }
        [StringLength(50)]
        public string varTaxRate { get; set; }
        [StringLength(50)]
        public string varMarginRstax { get; set; }
        [StringLength(50)]
        public string varmarginPerTax { get; set; }
        [StringLength(50)]
        public string varTotal { get; set; }
        public int? intUnitId { get; set; }
        public int? intComUnitId { get; set; }
        public double? flunitConvert { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intCategoryID { get; set; }
        public int? intSubCategoryID { get; set; }
        public int? imgProduct { get; set; }
        [StringLength(500)]
        public string imagepath { get; set; }
        [StringLength(500)]
        public string varDesc { get; set; }
        public bool? isVisible { get; set; }
        [StringLength(60)]
        public string varBrand { get; set; }
        public bool? isAddon { get; set; }
        public bool? isActive { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flOpeningQty { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flOpeningRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOppDate { get; set; }
        public double? flPercentage { get; set; }
        [StringLength(200)]
        public string varUrduName { get; set; }
        public int? intDept { get; set; }
        public bool? isGateStockable { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string varInStockType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtExpiryDate { get; set; }
        [StringLength(250)]
        public string varQuality { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? flValueItem { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? flValueStock { get; set; }
    }
}
