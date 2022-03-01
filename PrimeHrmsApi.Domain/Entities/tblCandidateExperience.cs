using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCandidateExperience
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterID { get; set; }
        [StringLength(250)]
        public string varCompanyName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTo { get; set; }
        [StringLength(250)]
        public string varDesignation { get; set; }
        [StringLength(250)]
        public string varLocation { get; set; }
        [StringLength(1500)]
        public string varReasonForLeaving { get; set; }
        public int? intCompanyID { get; set; }
    }
}
