using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAllowAttendanceEmails
    {
        [Key]
        public int intSeqId { get; set; }
        public bool? isAllowLateEmails { get; set; }
        public bool? isAllowAbsentEmails { get; set; }
        public bool? isAllowWeeklyAttEmails { get; set; }
        public bool? isAllowDailyAttEmails { get; set; }
    }
}
