using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSwapRosterShiftLog
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intFirstEmpId { get; set; }
        public int? intSecondEmpId { get; set; }
        public int? intFirstEmpOldShiftId { get; set; }
        public int? intSecondEmplOldShiftId { get; set; }
        public int? intFirstEmpNewShiftId { get; set; }
        public int? intSecondEmplNewShiftId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
    }
}
