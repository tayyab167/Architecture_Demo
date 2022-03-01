using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLeaves
    {
        [Key]
        public int intSeqID { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string varReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intDays { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intBranchID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        public int? intMasterId { get; set; }
        public int? intLeaveType { get; set; }
        public bool? isAppRej { get; set; }
        public int? intAppRejBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAppRejDate { get; set; }
        [StringLength(3000)]
        public string varAppRejDetails { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLeaveEndPeriod { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLeaveStartPeriod { get; set; }
        [StringLength(200)]
        public string varFilePath1 { get; set; }
        [StringLength(200)]
        public string varFilePath2 { get; set; }
        [StringLength(200)]
        public string varFilePath3 { get; set; }
        public int? intLeavePeriodId { get; set; }
        [StringLength(50)]
        public string varDayType { get; set; }
        [StringLength(50)]
        public string vartype { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToTime { get; set; }
        [StringLength(50)]
        public string LeaveStatus { get; set; }
        [StringLength(50)]
        public string var1stHalf2ndHalf { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAgainstDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAgainstDateClockIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAgainstDateClockOut { get; set; }
        public int? intBloodRelation { get; set; }
        [StringLength(50)]
        public string varCompansationType { get; set; }
    }
}
