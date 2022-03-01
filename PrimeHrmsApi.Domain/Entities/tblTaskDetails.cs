using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaskDetails
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intTaskMgmtId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intLocationId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndTime { get; set; }
        public int? intRemindBefore { get; set; }
        public int? intAssignedEmp { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
