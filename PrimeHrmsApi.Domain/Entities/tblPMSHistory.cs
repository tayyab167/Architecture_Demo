using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSHistory
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmpIdMaster { get; set; }
        [StringLength(750)]
        public string varDescription { get; set; }
        public int? intEmpIdAgainst { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtHistoryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCompanyId { get; set; }
    }
}
