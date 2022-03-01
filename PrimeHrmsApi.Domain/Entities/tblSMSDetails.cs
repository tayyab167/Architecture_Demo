using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSMSDetails
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varPhone { get; set; }
        [StringLength(160)]
        public string varMessage { get; set; }
        public bool? isSend { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreation { get; set; }
    }
}
