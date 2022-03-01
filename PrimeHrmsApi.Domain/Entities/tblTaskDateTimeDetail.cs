using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaskDateTimeDetail
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varUserType { get; set; }
        public int? intEmployeeID { get; set; }
        public int? intMasterID { get; set; }
        public int? intCompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDateTask { get; set; }
        public TimeSpan? dtTimeTask { get; set; }
        public double? dtTimeTaskHours { get; set; }
        public double? dtTimeTaskMint { get; set; }
        public TimeSpan? dtTimeTaskStart { get; set; }
        public TimeSpan? dtTimeTaskEnd { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
    }
}
