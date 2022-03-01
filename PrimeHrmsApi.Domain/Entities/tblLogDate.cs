using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLogDate
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intRecordId { get; set; }
        public int? intUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string varAction { get; set; }
        [StringLength(50)]
        public string varTableName { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intReferenceID { get; set; }
        [StringLength(500)]
        public string varType { get; set; }
        public int? intRecordMasterId { get; set; }
        [StringLength(50)]
        public string varIPAddress { get; set; }
    }
}
