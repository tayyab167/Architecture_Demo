using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblVehicalType
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string intregistrationNo { get; set; }
        [StringLength(50)]
        public string varChaseNo { get; set; }
        [StringLength(50)]
        public string varModel { get; set; }
        [StringLength(50)]
        public string varBrand { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatePurchase { get; set; }
        [StringLength(50)]
        public string varPurchaseamount { get; set; }
        [StringLength(50)]
        public string varVehicalcolor { get; set; }
        public int? intCondition { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public double? purchaseTime { get; set; }
        [StringLength(50)]
        public string varAttachfile1 { get; set; }
        [StringLength(50)]
        public string varAttachfile2 { get; set; }
        [StringLength(50)]
        public string varAttachfile3 { get; set; }
        [StringLength(50)]
        public string varAttachfile4 { get; set; }
        [StringLength(250)]
        public string varStatus { get; set; }
        public int? intBillNo { get; set; }
        public int? intCurrentMillage { get; set; }
        public int? intYear { get; set; }
        [StringLength(20)]
        public string varCC { get; set; }
        [StringLength(250)]
        public string varDescription { get; set; }
        [StringLength(20)]
        public string varType { get; set; }
        [StringLength(20)]
        public string varVehicleNo { get; set; }
        public int? intMake { get; set; }
    }
}
