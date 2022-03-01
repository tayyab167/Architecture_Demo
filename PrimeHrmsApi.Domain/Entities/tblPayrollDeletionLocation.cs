using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPayrollDeletionLocation
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(550)]
        public string flLong { get; set; }
        [StringLength(550)]
        public string flLat { get; set; }
        public int? intCompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [StringLength(150)]
        public string varPayrollDates { get; set; }
        public int? intCreatedBy { get; set; }
        [StringLength(250)]
        public string varBy { get; set; }
    }
}
