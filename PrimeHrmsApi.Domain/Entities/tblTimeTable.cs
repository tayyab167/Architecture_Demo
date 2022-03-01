using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTimeTable
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intSlotId { get; set; }
        [StringLength(50)]
        public string varDay { get; set; }
        public int? intClassId { get; set; }
        public int? intSectionId { get; set; }
        public int? intTeacherId { get; set; }
        public int? intSubjectId { get; set; }
        public int? intRoomId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
    }
}
