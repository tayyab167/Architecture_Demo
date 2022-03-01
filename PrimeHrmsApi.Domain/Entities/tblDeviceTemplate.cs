using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDeviceTemplate
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varDeviceIp { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intFingerIndex { get; set; }
        [StringLength(50)]
        public string varPassword { get; set; }
        public int? intprvlg { get; set; }
        public bool? isEnabled { get; set; }
        public int? intflag { get; set; }
        [StringLength(4000)]
        public string varTemplateData { get; set; }
        public int? intCompanyId { get; set; }
    }
}
