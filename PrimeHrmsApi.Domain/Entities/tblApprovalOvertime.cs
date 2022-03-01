using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblApprovalOvertime
    {
        [Key]
        public int intSeqId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public double? flBasicOtHours { get; set; }
        public double? flBasicOTAmount { get; set; }
        public double? flPHourRate { get; set; }
        public double? flProcessedOTAmount { get; set; }
        public bool? isApproved { get; set; }
        public double? flProcessedHour { get; set; }
        public int? intMasterId { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public bool? isOTInitiate { get; set; }
        public bool? isProcess { get; set; }
    }
}
