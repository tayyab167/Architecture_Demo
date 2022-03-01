using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblComments
    {
        [Key]
        public int intSeqId { get; set; }
        public string varComment { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intGroupId { get; set; }
        [StringLength(50)]
        public string varTitle { get; set; }
        [StringLength(1000)]
        public string varfilePath { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intupdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isRead { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public bool? isEmail { get; set; }
        public int? intNoticeId { get; set; }
        public int? intReplyId { get; set; }
        [StringLength(50)]
        public string varEmpType { get; set; }
        [StringLength(70)]
        public string varCC { get; set; }
        [StringLength(70)]
        public string varBCC { get; set; }
    }
}
