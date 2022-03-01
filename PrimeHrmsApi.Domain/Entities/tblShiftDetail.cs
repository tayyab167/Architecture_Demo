using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblShiftDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterShiftId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToTime { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intBranchID { get; set; }
    }
}
