using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaskMgmt
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intTaskCatId { get; set; }
        [StringLength(200)]
        public string varSubject { get; set; }
        [StringLength(200)]
        public string varAgenda { get; set; }
        public string varDescription { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intParentId { get; set; }
    }
}
