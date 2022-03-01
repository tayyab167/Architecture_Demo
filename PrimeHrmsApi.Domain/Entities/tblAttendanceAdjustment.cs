using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAttendanceAdjustment
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intLatesIns { get; set; }
        public int? intEarlyOuts { get; set; }
        public double? flLateAuth { get; set; }
        public double? flConvertedLateIns { get; set; }
        public double? flLateEarlyDed { get; set; }
        public int? intMissingTimes { get; set; }
        public double? flMissingAuth { get; set; }
        public double? flMissingDed { get; set; }
        public double? flTotalConvertedLeaves { get; set; }
        public double? flTotalDeduction { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        public bool? isAdjusted { get; set; }
    }
}
