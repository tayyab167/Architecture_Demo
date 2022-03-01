using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLateAttendanceExemption
    {
        public int? intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intEmpId { get; set; }
        public int? intCompanyid { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApproveDate { get; set; }
        public bool? isApproved { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [StringLength(250)]
        public string varReason { get; set; }
        public int? intApprovalId { get; set; }
    }
}
