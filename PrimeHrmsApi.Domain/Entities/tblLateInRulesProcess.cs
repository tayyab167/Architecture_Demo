using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLateInRulesProcess
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intRowNumId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(1000)]
        public string varRuleName { get; set; }
        public bool? IsActive { get; set; }
        public int? intToMint { get; set; }
        public int? IntFromMint { get; set; }
        public double? intDayOff { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intLeaveTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToDate { get; set; }
    }
}
