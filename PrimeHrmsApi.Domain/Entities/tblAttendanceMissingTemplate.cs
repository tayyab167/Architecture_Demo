using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAttendanceMissingTemplate
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(500)]
        public string varName { get; set; }
        public bool? isActive1 { get; set; }
        [StringLength(50)]
        public string varName1 { get; set; }
        public int? intFrom1 { get; set; }
        public int? intTo1 { get; set; }
        public int? intMargin1 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flHourDed1 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flFineDed1 { get; set; }
        public bool? isActive2 { get; set; }
        [StringLength(50)]
        public string varName2 { get; set; }
        public int? intFrom2 { get; set; }
        public int? intTo2 { get; set; }
        public int? intMargin2 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flHourDed2 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flFineDed2 { get; set; }
        public bool? isActive3 { get; set; }
        [StringLength(50)]
        public string varName3 { get; set; }
        public int? intFrom3 { get; set; }
        public int? intTo3 { get; set; }
        public int? intMargin3 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flHourDed3 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flFineDed3 { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
