using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDeductionStructure
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intDeductionId { get; set; }
        public double? flDeductionPercentage { get; set; }
        public double? flAmount { get; set; }
        public int? intAmountType { get; set; }
        public int? intMasterID { get; set; }
        public int? intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
