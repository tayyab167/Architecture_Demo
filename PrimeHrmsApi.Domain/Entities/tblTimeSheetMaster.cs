using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTimeSheetMaster
    {
        [Key]
        public int intSeqId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [StringLength(50)]
        public string varTimeSheetCode { get; set; }
        public int? intProjectId { get; set; }
        public int? intSOWId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTimeSheetDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromPeriod { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToPeriod { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intUpdatedBy { get; set; }
    }
}
