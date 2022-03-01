using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSalary
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [StringLength(100)]
        public string varSalaryType { get; set; }
        public double? flSalary { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public double? flRate { get; set; }
        public int? intBranchID { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isAuto { get; set; }
        public double? flGrossSalary { get; set; }
        public double? flBasicPerct { get; set; }
        public double? flDailySalaryPType { get; set; }
        public int? intPayrollStructureID { get; set; }
    }
}
