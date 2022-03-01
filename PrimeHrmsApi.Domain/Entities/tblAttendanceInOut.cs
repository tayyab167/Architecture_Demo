using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAttendanceInOut
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtClockIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtClockOut { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intShiftID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromShiftTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToShiftTime { get; set; }
        public int? intOverTimeDetailID { get; set; }
        public bool? isClockManual { get; set; }
        public int? intInOut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBreakStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBreakEnd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBreakStartAssign { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBreakEndAssign { get; set; }
    }
}
