using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLoginHistory
    {
        public int intSeqId { get; set; }
        public int? intUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLoginTime { get; set; }
        [StringLength(50)]
        public string varIpAddress { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public int? intEmployeeid { get; set; }
        public int? intClientId { get; set; }
        public int? intCompanyid { get; set; }
        public bool? isMobile { get; set; }
        public string varDeviceInfo { get; set; }
    }
}
