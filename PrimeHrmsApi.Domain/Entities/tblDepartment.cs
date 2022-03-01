using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDepartment
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varName { get; set; }
        [StringLength(200)]
        public string varDescription { get; set; }
        public int? intHod { get; set; }
        public bool? isShift { get; set; }
        public bool? isHour { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intParentID { get; set; }
        [StringLength(10)]
        public string varAbbri { get; set; }
        public int? intHODID { get; set; }
        public bool? isActiveESS { get; set; }
        public bool? isTrainingDeptWise { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flNormal { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPH { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWeekEnd { get; set; }
        public bool? onBoarding { get; set; }
        public int? empImage { get; set; }
        public int? qualification { get; set; }
        public int? experience { get; set; }
        public int? contact { get; set; }
        public int? dependants { get; set; }
        [StringLength(1000)]
        public string msg { get; set; }
        public bool? isAutoApproveManuallAttendance { get; set; }
        public int? nda { get; set; }
        public int? contract { get; set; }
        public int? signature { get; set; }
        public bool? isByPassTeamLead { get; set; }
        public int? intLateManualAttendanceMinutes { get; set; }
    }
}
