using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAnualBalance
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public double? flAnlbonsCompletion { get; set; }
        public double? flEligibleAnlBons { get; set; }
        public double? flAnlBonsResign { get; set; }
        public bool? isAnnualBonus { get; set; }
        [StringLength(50)]
        public string varAnnualBonusNameUsed { get; set; }
    }
}
