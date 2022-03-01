using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCompensationLeave
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public string varDescription { get; set; }
        public int? intEmployee { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? flHours { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDateComepensationAgainst { get; set; }
        public bool? isApprove { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtClockIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtClockOut { get; set; }
    }
}
