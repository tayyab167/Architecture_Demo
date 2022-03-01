using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDailyAttendanceAdjustment
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intEmployeeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAdjustmentDate { get; set; }
        public double? intAdjustDays { get; set; }
        public double? intAdjustAmount { get; set; }
        public double? intAdjustHours { get; set; }
        public double? intHoursAmount { get; set; }
        public double? intArrears { get; set; }
        public double? intOthers { get; set; }
        public int? intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(500)]
        public string varComments { get; set; }
    }
}
