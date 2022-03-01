using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblManualAttendanceEss
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtClockIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtClockOut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromShiftTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToShiftTime { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intWorkingHour { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intReasonId { get; set; }
        public string varComment { get; set; }
        public bool? isApprove { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public bool? isEss { get; set; }
        public int? intApproveBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApproveDate { get; set; }
        public bool? isAutoAppearPopUpAtt { get; set; }
    }
}
