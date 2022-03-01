using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDemandItemMaster
    {
        [Key]
        public int intSeqid { get; set; }
        [StringLength(50)]
        public string varName { get; set; }
        public int? intDesignation { get; set; }
        public int? intDepartment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtVoucherDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        [StringLength(50)]
        public string varRemarks { get; set; }
        [StringLength(50)]
        public string varVoucher { get; set; }
    }
}
