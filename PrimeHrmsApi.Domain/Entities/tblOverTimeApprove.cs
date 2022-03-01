using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOverTimeApprove
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOverTimeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOverTimeFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOverTimeTo { get; set; }
        public double? flClaimMinutes { get; set; }
        public double? flApprovedMinutes { get; set; }
        public bool? isApproved { get; set; }
        [StringLength(2000)]
        public string varDescriptionStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovedDate { get; set; }
        public int? intAppliedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
