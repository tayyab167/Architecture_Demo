using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblMenualBreak
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBreakInTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBreakOutTime { get; set; }
        public string varReson { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? intUpdatedDate { get; set; }
        public int? dtUpdatedBy { get; set; }
        public bool? isMenual { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
