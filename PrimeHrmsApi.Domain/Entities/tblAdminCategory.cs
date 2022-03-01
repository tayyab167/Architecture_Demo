using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAdminCategory
    {
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varName { get; set; }
        [StringLength(500)]
        public string varDesc { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreation { get; set; }
        public int? intUpdatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdate { get; set; }
    }
}
