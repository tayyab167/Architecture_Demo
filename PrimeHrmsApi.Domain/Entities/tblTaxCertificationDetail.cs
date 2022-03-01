using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaxCertificationDetail
    {
        [Key]
        public int IntSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(50)]
        public string dtDepositDate { get; set; }
        [StringLength(50)]
        public string varBankTreasury { get; set; }
        public int? intAmount { get; set; }
        public int? intBranchId { get; set; }
        [StringLength(50)]
        public string varChallan { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedby { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intCompanyId { get; set; }
        public int? intTaxPeriodId { get; set; }
    }
}
