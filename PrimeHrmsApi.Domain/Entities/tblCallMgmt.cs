using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCallMgmt
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varPhoneNumber { get; set; }
        [StringLength(50)]
        public string varFrom { get; set; }
        [StringLength(50)]
        public string varTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCallTime { get; set; }
        [StringLength(50)]
        public string varAttendBy { get; set; }
        [StringLength(500)]
        public string varReason { get; set; }
        [StringLength(50)]
        public string varCompanyName { get; set; }
        [StringLength(50)]
        public string varInOut { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
