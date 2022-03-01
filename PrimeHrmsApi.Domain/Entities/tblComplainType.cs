using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblComplainType
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varComplainType { get; set; }
        [StringLength(1000)]
        public string varDescription { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedby { get; set; }
        public int? intUpdatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isActive { get; set; }
    }
}
