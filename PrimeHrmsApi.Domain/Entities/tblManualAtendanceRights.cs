using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblManualAtendanceRights
    {
        public int? intSeqId { get; set; }
        public int? intPreviousApplyDays { get; set; }
        public int? intNextDaysApplyleave { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreatedDate { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isActiveRightsManual { get; set; }
    }
}
