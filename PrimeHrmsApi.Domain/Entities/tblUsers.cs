using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblUsers
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varName { get; set; }
        [StringLength(100)]
        public string varEmail { get; set; }
        [StringLength(50)]
        public string varPhone { get; set; }
        public int? intUnitId { get; set; }
        [StringLength(100)]
        public string varUserName { get; set; }
        [StringLength(100)]
        public string varPassword { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public int? intTypeId { get; set; }
        [StringLength(50)]
        public string varLevel { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(1000)]
        public string varGroup { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public bool? ischecktimesheet { get; set; }
        public int? intTimeSheetManagerId { get; set; }
        [StringLength(50)]
        public string intBranchId { get; set; }
        public int? intDepartment { get; set; }
        public bool? isSuperUser { get; set; }
        [StringLength(100)]
        public string varAllowMgmt { get; set; }
        [StringLength(100)]
        public string varPayrollProcess { get; set; }
        [StringLength(100)]
        public string varDashboardGrid { get; set; }
        [Required]
        public bool? isActive { get; set; }
        public bool? ispayrollEditOption { get; set; }
        public bool? isATSUser { get; set; }
        [StringLength(50)]
        public string varStartUpPage { get; set; }
        public bool? isApproveRejectAllowLetter { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUserInActiveDate { get; set; }
        [StringLength(200)]
        public string varInActiveReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUserInActiveReJoinDate { get; set; }
    }
}
