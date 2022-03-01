using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCompensationAttendance
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCompensationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCompensationAgainstDate { get; set; }
        [StringLength(50)]
        public string dtClockIn { get; set; }
        [StringLength(50)]
        public string dtClockOut { get; set; }
        public bool? isApprove { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [StringLength(2000)]
        public string varNote { get; set; }
    }
}
