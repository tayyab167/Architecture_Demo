using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCompany
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(250)]
        public string varCompanyName { get; set; }
        [StringLength(250)]
        public string varEmail { get; set; }
        [StringLength(500)]
        public string varAddress { get; set; }
        [StringLength(50)]
        public string varPhone { get; set; }
        [StringLength(50)]
        public string varNtn { get; set; }
        [Column(TypeName = "image")]
        public byte[] imgLogo { get; set; }
        [Column(TypeName = "image")]
        public byte[] imgBanner { get; set; }
        [StringLength(200)]
        public string varBannerImage { get; set; }
        [StringLength(200)]
        public string varHeaderImage { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(200)]
        public string varperson1Name { get; set; }
        [StringLength(200)]
        public string varperson1Email { get; set; }
        [StringLength(200)]
        public string varperson1Phone { get; set; }
        [StringLength(200)]
        public string varPerson1Address { get; set; }
        [StringLength(200)]
        public string varperson2Name { get; set; }
        [StringLength(200)]
        public string varperson2Email { get; set; }
        [StringLength(200)]
        public string varperson2Phone { get; set; }
        [StringLength(200)]
        public string varPerson2Address { get; set; }
        [StringLength(300)]
        public string varCode { get; set; }
        [Column(TypeName = "image")]
        public byte[] imgpayrol { get; set; }
        [StringLength(200)]
        public string varpayrollImage { get; set; }
        [StringLength(50)]
        public string varTotalEmployee { get; set; }
        [StringLength(50)]
        public string varCompanyType { get; set; }
        [StringLength(200)]
        public string varCountry { get; set; }
        public int? intCountryId { get; set; }
        [StringLength(200)]
        public string varState { get; set; }
        public int? intStateId { get; set; }
        [StringLength(200)]
        public string varCity { get; set; }
        public int? intCityId { get; set; }
        [StringLength(200)]
        public string varTimeZone { get; set; }
        public double? flTimeZoneValue { get; set; }
        public int? intSetUserLimit { get; set; }
        public int? intSetEmpLimit { get; set; }
        public bool? isActive { get; set; }
        [StringLength(200)]
        public string varCurrency { get; set; }
        [StringLength(200)]
        public string varDateFormat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        [StringLength(500)]
        public string varCompanyUrl { get; set; }
        [StringLength(500)]
        public string varLink { get; set; }
        public int? intGroupId { get; set; }
        [StringLength(150)]
        public string varATSTitle { get; set; }
        [StringLength(30)]
        public string varShortAddress { get; set; }
        [StringLength(150)]
        public string varCompanyWebSite { get; set; }
        public int? intTaxCertificateManagerEmp { get; set; }
        public bool? intNewPayrollLink { get; set; }
        [StringLength(150)]
        public string varCNICFormat { get; set; }
        public bool? isAllowLateEmails { get; set; }
    }
}
