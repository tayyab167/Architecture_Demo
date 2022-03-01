using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOrderMgmt
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varSubject { get; set; }
        public int? intLocId { get; set; }
        public int? intHallId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFunctionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFunctionTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFunctionToTime { get; set; }
        [StringLength(200)]
        public string varTotalGuestUnConfirmed { get; set; }
        public int? intTotalGuest { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPGuestPrice { get; set; }
        public int? intTaxableGuest { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flTaxablePerGuest { get; set; }
        [StringLength(500)]
        public string varDesc { get; set; }
        public bool? IsEnteranceDecoration { get; set; }
        public bool? IsStageDecoration { get; set; }
        public bool? IsHallDecoration { get; set; }
        public bool? IsParking { get; set; }
        public bool? IsDispToilets { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtConfirmDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtProcessDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCloseDate { get; set; }
        [StringLength(100)]
        public string varStatus { get; set; }
        public int? intBillno { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flBillAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBillPaidDate { get; set; }
        public int? intPresentGuest { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPresentAmount { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPaidAmount { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flDiscount { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPriceEnteranceDecoration { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPriceStageDecoration { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPriceHallDecoration { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPriceParking { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPriceToilets { get; set; }
        [StringLength(200)]
        public string varCareOff { get; set; }
        public bool? IsPrivacy { get; set; }
        public int? intCustomerId { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(200)]
        public string varHall { get; set; }
        [StringLength(200)]
        public string varColorScheme { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOrderCancel { get; set; }
        [StringLength(1000)]
        public string varCancelReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtConfirmDateTime { get; set; }
        public int? intConfirmedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCanceledDateTime { get; set; }
        public int? intCanceledby { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWHT { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWaterCold { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flCold { get; set; }
        public int? flColdQty { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flColdPrice { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flStage { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flHallCharges { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flOrderDiscount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPendingDate { get; set; }
        public int? intPendingby { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flHeater { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flSound { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flByHost { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flParcel { get; set; }
        [StringLength(100)]
        public string varMealTime { get; set; }
        [StringLength(500)]
        public string varAdvanceRemarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPostponeDate { get; set; }
        public int? intPostponeby { get; set; }
        public int? intConfirmMenu { get; set; }
        public bool? isNotified { get; set; }
        public int? intVMasterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTentive { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWaterRate { get; set; }
        public int? flWaterQty { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flDiet { get; set; }
        public int? flDietQty { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flDietRate { get; set; }
        [StringLength(100)]
        public string varSoundSupplier { get; set; }
        [StringLength(100)]
        public string varStageSupplier { get; set; }
        public bool? IsStage { get; set; }
        public bool? IsSound { get; set; }
        [StringLength(50)]
        public string varColdDrinkType { get; set; }
        [StringLength(50)]
        public string varWaterType { get; set; }
        public double? flMuttonbyHostQty { get; set; }
        public double? flMuttonbyHostRate { get; set; }
        public double? flMuttonbyHostAmount { get; set; }
        [StringLength(50)]
        public string varMuttonType { get; set; }
        [StringLength(50)]
        public string varCNIC { get; set; }
        [StringLength(50)]
        public string varNTN { get; set; }
        [StringLength(50)]
        public string varHostPhone { get; set; }
        public int? intReceivable { get; set; }
        public int? intVMasterDiscount { get; set; }
        public int intCompanyId { get; set; }
    }
}
