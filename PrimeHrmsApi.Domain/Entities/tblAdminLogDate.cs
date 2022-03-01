using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAdminLogDate
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intRecordId { get; set; }
        public int? intUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public string varAction { get; set; }
        [StringLength(50)]
        public string varTableName { get; set; }
        [Key]
        public int intCompanyID { get; set; }
    }
}
