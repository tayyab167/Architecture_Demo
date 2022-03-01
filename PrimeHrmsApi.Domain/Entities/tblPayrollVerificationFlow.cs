using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPayrollVerificationFlow
    {
        public int? intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreatedDate { get; set; }
        [StringLength(50)]
        public string varPreparedby { get; set; }
        [StringLength(50)]
        public string varVerifiedby { get; set; }
        [StringLength(50)]
        public string varApprovedby { get; set; }
        [StringLength(100)]
        public string varPreparedbyEmail { get; set; }
        [StringLength(100)]
        public string varVerifiedbyEmail { get; set; }
        [StringLength(100)]
        public string varApprovedbyEmail { get; set; }
        [StringLength(200)]
        public string varPreparedbySign { get; set; }
        [StringLength(200)]
        public string varVerifiedbySign { get; set; }
        [StringLength(200)]
        public string varApprovedbySign { get; set; }
    }
}
