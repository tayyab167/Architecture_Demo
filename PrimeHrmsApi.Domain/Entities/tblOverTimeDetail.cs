using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOverTimeDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOverTimeFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOverTimeTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOverTimeDate { get; set; }
        public bool? isApproved { get; set; }
        public double? flTotalClameTime { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovedDate { get; set; }
        [StringLength(4000)]
        public string varApprovedDiscription { get; set; }
        public int? intApprovedBY { get; set; }
        public double? flApprovedMinutes { get; set; }
        public int? intUpdatyedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public double? flRate { get; set; }
    }
}
