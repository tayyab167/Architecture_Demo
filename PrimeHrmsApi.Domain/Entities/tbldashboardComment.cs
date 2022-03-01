using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tbldashboardComment
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDateComment { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? dtCreatedby { get; set; }
        public int? updateby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdationDate { get; set; }
        [StringLength(200)]
        public string varHrsMin { get; set; }
        [StringLength(200)]
        public string varRemarks { get; set; }
        public int? intCompanyId { get; set; }
    }
}
