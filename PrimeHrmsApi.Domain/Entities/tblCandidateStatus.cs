using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCandidateStatus
    {
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varStatusName { get; set; }
        [StringLength(50)]
        public string varStatusColor { get; set; }
        public bool? isEmail { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isDefault { get; set; }
        public bool? isInterView { get; set; }
        public int? intSortingNumber { get; set; }
        public bool? isJoiningDate { get; set; }
        public bool? isShortListedComments { get; set; }
    }
}
