using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblHREmailSetting
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string varHREmail { get; set; }
        public bool? isApplyLeave { get; set; }
        public bool? isApproverejectLeave { get; set; }
        [StringLength(500)]
        public string varFinanceEmail { get; set; }
    }
}
