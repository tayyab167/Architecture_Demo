using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLateAllowanceDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(100)]
        public string varRuleName { get; set; }
        public bool? IsActive { get; set; }
        public double? flAmount { get; set; }
        public double? flNoAbsents { get; set; }
        public int? intLateAllowance { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }

        [ForeignKey(nameof(intLateAllowance))]
        [InverseProperty(nameof(tblLateAllowance.tblLateAllowanceDetail))]
        public virtual tblLateAllowance intLateAllowanceNavigation { get; set; }
    }
}
