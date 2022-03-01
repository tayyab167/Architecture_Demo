using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblGoalsObjectiveDetail
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varObjective { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTodate { get; set; }
        public int? intMarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCompanyid { get; set; }
        public int? intMasterGoalId { get; set; }
        public int? intTotalMarks { get; set; }
    }
}
