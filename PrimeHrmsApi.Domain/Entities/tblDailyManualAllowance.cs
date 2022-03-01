using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDailyManualAllowance
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToDate { get; set; }
        public int? intEmpID { get; set; }
        [StringLength(10)]
        public string varType { get; set; }
        public double? flDay1 { get; set; }
        public double? flDay2 { get; set; }
        public double? flDay3 { get; set; }
        public double? flDay4 { get; set; }
        public double? flDay5 { get; set; }
        public double? flDay6 { get; set; }
        public double? flDay7 { get; set; }
        public double? flDay8 { get; set; }
        public double? flDay9 { get; set; }
        public double? flDay10 { get; set; }
        public double? flDay11 { get; set; }
        public double? flDay12 { get; set; }
        public double? flDay13 { get; set; }
        public double? flDay14 { get; set; }
        public double? flDay15 { get; set; }
        public double? flDay16 { get; set; }
        public double? flDay17 { get; set; }
        public double? flDay18 { get; set; }
        public double? flDay19 { get; set; }
        public double? flDay20 { get; set; }
        public double? flDay21 { get; set; }
        public double? flDay22 { get; set; }
        public double? flDay23 { get; set; }
        public double? flDay24 { get; set; }
        public double? flDay25 { get; set; }
        public double? flDay26 { get; set; }
        public double? flDay27 { get; set; }
        public double? flDay28 { get; set; }
        public double? flDay29 { get; set; }
        public double? flDay30 { get; set; }
        public double? flDay31 { get; set; }
        public double? flTotal { get; set; }
        [StringLength(50)]
        public string flDayType1 { get; set; }
        [StringLength(50)]
        public string flDayType2 { get; set; }
        [StringLength(50)]
        public string flDayType3 { get; set; }
        [StringLength(50)]
        public string flDayType4 { get; set; }
        [StringLength(50)]
        public string flDayType5 { get; set; }
        [StringLength(50)]
        public string flDayType6 { get; set; }
        [StringLength(50)]
        public string flDayType7 { get; set; }
        [StringLength(50)]
        public string flDayType8 { get; set; }
        [StringLength(50)]
        public string flDayType9 { get; set; }
        [StringLength(50)]
        public string flDayType10 { get; set; }
    }
}
