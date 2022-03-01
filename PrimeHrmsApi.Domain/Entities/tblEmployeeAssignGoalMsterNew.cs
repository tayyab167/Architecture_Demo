using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeAssignGoalMsterNew
    {
        public int? intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(50)]
        public string vardescription { get; set; }
        public int? intCompanyid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intObjectivesTotal { get; set; }
        public int? intGoalsTotal { get; set; }
        public bool? isstatus { get; set; }
        public int? intSendTo { get; set; }
        public int? intMasterAssignId { get; set; }
        public int? intManageID { get; set; }
    }
}
