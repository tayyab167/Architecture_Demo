using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTicketDetails
    {
        [Key]
        public int intSeqId { get; set; }
        public string varDescription { get; set; }
        public int? intMasterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCteationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
    }
}
