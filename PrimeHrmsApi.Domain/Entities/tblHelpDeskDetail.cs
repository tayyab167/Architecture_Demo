using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblHelpDeskDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmpId { get; set; }
        [StringLength(4000)]
        public string varDescription { get; set; }
        [StringLength(150)]
        public string varAttachment1 { get; set; }
        [StringLength(150)]
        public string varAttachment2 { get; set; }
        [StringLength(150)]
        public string varAttachment3 { get; set; }
        public int? intMasterId { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
    }
}
