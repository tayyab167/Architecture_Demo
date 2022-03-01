using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEarlyOutRulesNewProcess
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(1000)]
        public string varName { get; set; }
        public int? intRowNumId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(1000)]
        public string varRuleName1 { get; set; }
        public bool? IsActive1 { get; set; }
        public int? IntFromMint1 { get; set; }
        public int? intToMint1 { get; set; }
        public double? intDayOff1 { get; set; }
        public int? intMargin1 { get; set; }
        public int? intLimitDays1 { get; set; }
        [StringLength(1000)]
        public string varRuleName2 { get; set; }
        public bool? IsActive2 { get; set; }
        public int? IntFromMint2 { get; set; }
        public int? intToMint2 { get; set; }
        public double? intDayOff2 { get; set; }
        public int? intMargin2 { get; set; }
        public int? intLimitDays2 { get; set; }
        [StringLength(1000)]
        public string varRuleName3 { get; set; }
        public bool? IsActive3 { get; set; }
        public int? IntFromMint3 { get; set; }
        public int? intToMint3 { get; set; }
        public double? intDayOff3 { get; set; }
        public int? intMargin3 { get; set; }
        public int? intLimitDays3 { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCheckinDays { get; set; }
        public int? intEmployeeId { get; set; }
        public int? dtMonth { get; set; }
        public int? dtYear { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
    }
}
