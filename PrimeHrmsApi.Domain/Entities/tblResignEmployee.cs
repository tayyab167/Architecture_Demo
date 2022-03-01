using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblResignEmployee
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApplyDate { get; set; }
        public int? intNoticePeriod { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
        [StringLength(500)]
        public string varResignReasonEmployee { get; set; }
        [StringLength(500)]
        public string varResignAdminRemarks { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isApproveResign { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromNoticeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToNoticeDate { get; set; }
        public bool? isESS { get; set; }
        [StringLength(150)]
        public string varStatus { get; set; }
    }
}
