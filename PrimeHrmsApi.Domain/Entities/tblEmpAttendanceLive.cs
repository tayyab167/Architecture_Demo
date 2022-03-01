using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpAttendanceLive
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intRefId { get; set; }
        public int? intShiftId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndTime { get; set; }
        [StringLength(50)]
        public string Mode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTime { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
