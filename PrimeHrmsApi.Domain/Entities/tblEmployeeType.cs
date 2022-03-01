using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeType
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varName { get; set; }
        [StringLength(100)]
        public string varDescription { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intBranchID { get; set; }
        public bool? isLeaveAllow { get; set; }
        public bool? isPFAllow { get; set; }
        public bool? isFieldAllow { get; set; }
        public bool? isMedicalAllow { get; set; }
        public bool? isLeaveBalinMinus { get; set; }
        public bool? isPMSAllow { get; set; }
        public bool? isPermanentType { get; set; }
        public bool? isOPDAllow { get; set; }
        [StringLength(50)]
        public string varJobTypeATS { get; set; }
        public bool? isSendEmail { get; set; }
        public bool? dontAllowLQuotaAtFirstTime { get; set; }
        public int? intNoticePeriod { get; set; }
    }
}
