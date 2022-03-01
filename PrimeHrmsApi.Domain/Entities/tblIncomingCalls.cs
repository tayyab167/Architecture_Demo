using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblIncomingCalls
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [StringLength(50)]
        public string varCallerName { get; set; }
        [StringLength(250)]
        public string varSubject { get; set; }
        [StringLength(200)]
        public string varTransferTo { get; set; }
        [StringLength(200)]
        public string varOtherActions { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        [StringLength(15)]
        public string varType { get; set; }
    }
}
