using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTicketMaster
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(500)]
        public string varSubject { get; set; }
        public string varQuestion { get; set; }
        public string varDetails { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(500)]
        public string varImage { get; set; }
        public bool? islow { get; set; }
        public bool? ishigh { get; set; }
    }
}
