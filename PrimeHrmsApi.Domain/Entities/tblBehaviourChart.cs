using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblBehaviourChart
    {
        public int? intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intAvgRed { get; set; }
        public int? intAvgYellow { get; set; }
        public int? intAvgGreen { get; set; }
        public int? intAvgMax { get; set; }
        public int? intAvgprct { get; set; }
        public int? intLateRed { get; set; }
        public int? intLateYellow { get; set; }
        public int? intLateGreenn { get; set; }
        public int? intLateMaxium { get; set; }
        public int? intLateprct { get; set; }
        public int? intleaveRed { get; set; }
        public int? intleaveYellow { get; set; }
        public int? intleaveGreen { get; set; }
        public int? intleaveMaxium { get; set; }
        public int? intleaveprct { get; set; }
        public int? inttotalAvrg { get; set; }
        public int? inttotallate { get; set; }
        public int? inttotalleave { get; set; }
    }
}
