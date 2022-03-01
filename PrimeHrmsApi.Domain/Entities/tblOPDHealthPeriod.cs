using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOPDHealthPeriod
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intCreatedby { get; set; }
        public int? intUpdateby { get; set; }
        public string varDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToDate { get; set; }
        public bool? isActive { get; set; }
        public int? intPrePeriod { get; set; }
        public int intCompanyId { get; set; }
        public double? intEmployeeContribution { get; set; }
        public double? intCompanyContribution { get; set; }
        public double? intOPDLimitFrom { get; set; }
        public double? intOPDLimitTo { get; set; }
        public double? intPremiumYear { get; set; }
    }
}
