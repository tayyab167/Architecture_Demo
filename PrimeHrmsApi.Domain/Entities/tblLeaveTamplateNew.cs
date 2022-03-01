using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLeaveTamplateNew
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [StringLength(100)]
        public string varQouta { get; set; }
        public bool? isForwarded { get; set; }
        public bool? ispaid { get; set; }
        public int? intLeaveId { get; set; }
        public int? intleaveperoid { get; set; }
        public int? varHours { get; set; }
        [StringLength(100)]
        public string vartype { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
