using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSScheduler
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCompanyId { get; set; }
        public int? intDesignationId { get; set; }
        [StringLength(50)]
        public string varDeadLineDay { get; set; }
        public bool? isAllowWarning { get; set; }
        [StringLength(100)]
        public string varWarningMessage { get; set; }
    }
}
