using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblResignDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intResignId { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(50)]
        public string varLevel { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        public bool? isApproved { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dtCreatedDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovalDate { get; set; }
        public int? intResignEmployeeId { get; set; }
        [StringLength(2000)]
        public string varComments { get; set; }
    }
}
