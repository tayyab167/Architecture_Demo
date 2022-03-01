using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPayRollDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? dtMonth { get; set; }
        public int? dtYear { get; set; }
        public int? intIncentiveTypeId { get; set; }
        public int intDeductionTypeId { get; set; }
        public int? intBenefitTypeId { get; set; }
        public double? flIncentive { get; set; }
        public double? flDeduction { get; set; }
        public double? flBenefit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intMasterId { get; set; }
        [StringLength(50)]
        public string varVoucherType { get; set; }
        public double? flValue { get; set; }
    }
}
