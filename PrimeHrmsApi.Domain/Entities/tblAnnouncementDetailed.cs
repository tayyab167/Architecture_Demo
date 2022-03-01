using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAnnouncementDetailed
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intBranchId { get; set; }
        public int? intDesignationId { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isViewed { get; set; }
        public bool? isAcknowledged { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDtTmViewed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDtTmAcknowledged { get; set; }
        public int? intCreatedBy { get; set; }
    }
}
