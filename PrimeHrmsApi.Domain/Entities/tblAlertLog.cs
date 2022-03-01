using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAlertLog
    {
        [Key]
        public int intSeqid { get; set; }
        public int? intUserId { get; set; }
        public int? intEmpId { get; set; }
        [StringLength(150)]
        public string varDesc { get; set; }
        public int? intRefId { get; set; }
        [StringLength(150)]
        public string varRefTableName { get; set; }
        public int? intResponseFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtActionDate { get; set; }
        [StringLength(50)]
        public string isLike { get; set; }
        [StringLength(500)]
        public string varMsg { get; set; }
        public int? intCompanyId { get; set; }
    }
}
