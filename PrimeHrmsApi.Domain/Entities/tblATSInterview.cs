using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblATSInterview
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dtinterViewDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndTime { get; set; }
        public int? intInterviewId { get; set; }
        public int? intCandidateId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intInterviewerId { get; set; }
        public bool? isConducted { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dtConductedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtConductStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtConductEndTime { get; set; }
        public bool? isReScheduled { get; set; }
        public bool? isCancelled { get; set; }
        [StringLength(500)]
        public string varCRNote { get; set; }
        [StringLength(3000)]
        public string varNotes { get; set; }
    }
}
