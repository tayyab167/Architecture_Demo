using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmailSetting
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varFromEmail { get; set; }
        [StringLength(50)]
        public string varUserName { get; set; }
        [StringLength(50)]
        public string varPassword { get; set; }
        [StringLength(50)]
        public string varHost { get; set; }
        [StringLength(50)]
        public string varPort { get; set; }
        public bool? isSSL { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
