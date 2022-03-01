using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAttendanceWatcher
    {
        [Key]
        public int IntSeqId { get; set; }
        public int? IntCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartExecution { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndExecution { get; set; }
        public int? intCount { get; set; }
        [StringLength(2000)]
        public string varException { get; set; }
    }
}
