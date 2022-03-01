using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblReceptionMgmt
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varCard { get; set; }
        [StringLength(50)]
        public string varPersonName { get; set; }
        [StringLength(50)]
        public string varCnic { get; set; }
        [StringLength(50)]
        public string varCompany { get; set; }
        [StringLength(500)]
        public string varAddress { get; set; }
        [StringLength(2000)]
        public string varReason { get; set; }
        [StringLength(50)]
        public string varMeetPerson { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtInTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOutTime { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
