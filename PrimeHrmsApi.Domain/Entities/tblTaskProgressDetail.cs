using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaskProgressDetail
    {
        public int? intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPauseTime { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public string varPauseReason { get; set; }
        public int? intEmployeeId { get; set; }
        public bool? isStuck { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? isDateStcukNew { get; set; }
        [StringLength(50)]
        public string varStuckReason { get; set; }
        [StringLength(200)]
        public string varNewLogReason { get; set; }
    }
}
