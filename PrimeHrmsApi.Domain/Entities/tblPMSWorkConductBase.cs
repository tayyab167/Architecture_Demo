using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSWorkConductBase
    {
        [Key]
        public int intSeqId { get; set; }
        public double? flWorkBase { get; set; }
        public double? flConductBase { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBY { get; set; }
        public double? flJan { get; set; }
        public double? flFeb { get; set; }
        public double? flMar { get; set; }
        public double? flApr { get; set; }
        public double? flMay { get; set; }
        public double? flJun { get; set; }
        public double? flJul { get; set; }
        public double? flAug { get; set; }
        public double? flSep { get; set; }
        public double? flOct { get; set; }
        public double? flNov { get; set; }
        public double? flDec { get; set; }
        public double? flFlatIncrement { get; set; }
        public double? flPerformanceIncrement { get; set; }
        [StringLength(50)]
        public string varMonthsSelect { get; set; }
        [StringLength(50)]
        public string varYearView { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEligibilityCriteria { get; set; }
        [StringLength(4)]
        public string txtTillPrevDays { get; set; }
        [StringLength(4)]
        public string txtTillNextDays { get; set; }
    }
}
