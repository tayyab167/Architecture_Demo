using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblContactLedge
    {
        public int? intSeqId { get; set; }
        [StringLength(250)]
        public string varName { get; set; }
        [StringLength(500)]
        public string varEmail { get; set; }
        [StringLength(3000)]
        public string varMessage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
