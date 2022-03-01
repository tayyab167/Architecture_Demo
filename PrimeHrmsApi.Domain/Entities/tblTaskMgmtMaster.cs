using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaskMgmtMaster
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTaskDate { get; set; }
        [StringLength(400)]
        public string varTaskTitle { get; set; }
        [StringLength(1000)]
        public string varTaskDescription { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        public int intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(1000)]
        public string varReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCopmleteDate { get; set; }
        [StringLength(400)]
        public string varFilePath { get; set; }
        public bool? isComplete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTaskComplete { get; set; }
        public int? intProjectId { get; set; }
        public int? intCategoryId { get; set; }
        public int? intClientId { get; set; }
        [StringLength(250)]
        public string varTags { get; set; }
        public int? intEmployeeStuck { get; set; }
        public int? isStuckEmp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStuckTime { get; set; }
        public double? dtBudgetMin { get; set; }
        public double? dtbudgetHours { get; set; }
        public int? intParentID { get; set; }
        public int? intTaskLabel { get; set; }
        public int? intRating { get; set; }
    }
}
