using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDailyManualAttendance
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
        [StringLength(50)]
        public string flDay1 { get; set; }
        [StringLength(50)]
        public string flDay2 { get; set; }
        [StringLength(50)]
        public string flDay3 { get; set; }
        [StringLength(50)]
        public string flDay4 { get; set; }
        [StringLength(50)]
        public string flDay5 { get; set; }
        [StringLength(50)]
        public string flDay6 { get; set; }
        [StringLength(50)]
        public string flDay7 { get; set; }
        [StringLength(50)]
        public string flDay8 { get; set; }
        [StringLength(50)]
        public string flDay9 { get; set; }
        [StringLength(50)]
        public string flDay10 { get; set; }
        [StringLength(50)]
        public string flDay11 { get; set; }
        [StringLength(50)]
        public string flDay12 { get; set; }
        [StringLength(50)]
        public string flDay13 { get; set; }
        [StringLength(50)]
        public string flDay14 { get; set; }
        [StringLength(50)]
        public string flDay15 { get; set; }
        [StringLength(50)]
        public string flDay16 { get; set; }
        [StringLength(50)]
        public string flDay17 { get; set; }
        [StringLength(50)]
        public string flDay18 { get; set; }
        [StringLength(50)]
        public string flDay19 { get; set; }
        [StringLength(50)]
        public string flDay20 { get; set; }
        [StringLength(50)]
        public string flDay21 { get; set; }
        [StringLength(50)]
        public string flDay22 { get; set; }
        [StringLength(50)]
        public string flDay23 { get; set; }
        [StringLength(50)]
        public string flDay24 { get; set; }
        [StringLength(50)]
        public string flDay25 { get; set; }
        [StringLength(50)]
        public string flDay26 { get; set; }
        [StringLength(50)]
        public string flDay27 { get; set; }
        [StringLength(50)]
        public string flDay28 { get; set; }
        [StringLength(50)]
        public string flDay29 { get; set; }
        [StringLength(50)]
        public string flDay30 { get; set; }
        [StringLength(50)]
        public string flDay31 { get; set; }
        public double? flTotal { get; set; }
        public double? flTotalPresent { get; set; }
        public double? flTotalAbsent { get; set; }
        public double? flTotalHalfDay { get; set; }
        public double? flTotalQuarterDay { get; set; }
        public double? flTotalLeave { get; set; }
        public double? flTotalHalfLeave { get; set; }
        public double? flTotalQuarterLeave { get; set; }
        public double? flTotalHoliday { get; set; }
        public double? flTotalOFFDay { get; set; }
    }
}
