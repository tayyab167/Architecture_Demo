using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblIssueMaster
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtVoucherDate { get; set; }
        [StringLength(50)]
        public string varVoucher { get; set; }
        public int? intToLocation { get; set; }
        public int? intFromLocation { get; set; }
        [StringLength(50)]
        public string varRef { get; set; }
        [StringLength(500)]
        public string varRemarks { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public bool? isvisible { get; set; }
        public int? intDepid { get; set; }
        public int? intOrderId { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        [StringLength(50)]
        public string varIssueType { get; set; }
        [StringLength(100)]
        public string varCategory { get; set; }
        public int? intSubDep { get; set; }
        public int? intCompanyId { get; set; }
    }
}
