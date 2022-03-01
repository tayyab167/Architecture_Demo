using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCandidateQuestionnaire
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterID { get; set; }
        public bool? isRelativeEmp { get; set; }
        public bool? isEmpBefore { get; set; }
        public bool? isDismissed { get; set; }
        public bool? isObjection { get; set; }
        public bool? isEmpPresent { get; set; }
        [StringLength(500)]
        public string varRelativeName { get; set; }
        [StringLength(250)]
        public string varRelativeDesignation { get; set; }
        [StringLength(1200)]
        public string varDismissedReason { get; set; }
        [StringLength(1200)]
        public string varObjectionReason { get; set; }
        [StringLength(500)]
        public string varCurrentEmployer { get; set; }
        [StringLength(50)]
        public string varCurrentEmpContact { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
