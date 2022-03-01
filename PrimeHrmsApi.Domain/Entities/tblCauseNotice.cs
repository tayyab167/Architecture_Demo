using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCauseNotice
    {
        public int? intSeqId { get; set; }
        [StringLength(350)]
        public string varCause { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationdate { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedate { get; set; }
        public int? intUpdatedBy { get; set; }
    }
}
