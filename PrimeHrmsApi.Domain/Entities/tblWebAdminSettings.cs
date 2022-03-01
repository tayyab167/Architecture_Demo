using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblWebAdminSettings
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varCompanyName { get; set; }
        [StringLength(50)]
        public string varCompanyAddress { get; set; }
        [StringLength(50)]
        public string varCity { get; set; }
        [StringLength(50)]
        public string varState { get; set; }
        public int? intZipCode { get; set; }
        [StringLength(50)]
        public string varPhoneNo { get; set; }
        [StringLength(50)]
        public string varCellNo { get; set; }
        [StringLength(50)]
        public string varCompanyLogo { get; set; }
        [StringLength(50)]
        public string varHost { get; set; }
        [StringLength(50)]
        public string varFromEmail { get; set; }
        [StringLength(50)]
        public string varToEmail { get; set; }
        public int? intPort { get; set; }
        [StringLength(50)]
        public string varUserName { get; set; }
        [StringLength(50)]
        public string varPassword { get; set; }
        [StringLength(50)]
        public string varPaypalEmail { get; set; }
        public double? flReferalPointPerDollar { get; set; }
        public double? flCommissionPercentage { get; set; }
        public double? flReferalPercentage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [Key]
        public int intCompanyID { get; set; }
    }
}
