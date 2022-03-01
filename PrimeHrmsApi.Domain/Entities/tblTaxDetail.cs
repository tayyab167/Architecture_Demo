using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaxDetail
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intMasterTaxID { get; set; }
        public int? intDepartmentId { get; set; }
        public double? flFromAmount { get; set; }
        public double? flToAmount { get; set; }
        [StringLength(500)]
        public string varTaxName { get; set; }
        public double? flRate { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intBranchID { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
    }
}
