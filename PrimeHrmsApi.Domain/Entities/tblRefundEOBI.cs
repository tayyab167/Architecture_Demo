using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblRefundEOBI
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intRowNumId { get; set; }
        [StringLength(1000)]
        public string varRuleName { get; set; }
        [StringLength(50)]
        public string intEmpPF { get; set; }
        [StringLength(50)]
        public string intCompPF { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
