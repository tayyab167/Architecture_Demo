using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSTaskCategory
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varName { get; set; }
        public int? intCreatedBY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBY { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(100)]
        public string varAbbr { get; set; }
        public double? flValue { get; set; }
        public bool? isPMSTaskCategory { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
    }
}
