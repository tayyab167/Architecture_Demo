using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLeaveApprovalFlowSave
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intLeaveSeqId { get; set; }
        public int? intApprovalId { get; set; }
        public bool? isApprove { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApproveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [StringLength(50)]
        public string varNote { get; set; }
        [StringLength(50)]
        public string varLevelType { get; set; }
    }
}
