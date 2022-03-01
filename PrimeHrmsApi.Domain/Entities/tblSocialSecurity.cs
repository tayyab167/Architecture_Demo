using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSocialSecurity
    {
        public int? intSeqId { get; set; }
        [StringLength(50)]
        public string varSecSalary { get; set; }
        public int? intBasicSalary { get; set; }
        [StringLength(50)]
        public string varBasicprcntG { get; set; }
        [StringLength(50)]
        public string varBasicprcntL { get; set; }
        public int? intGrossSalary { get; set; }
        [StringLength(50)]
        public string varGrssprcntG { get; set; }
        [StringLength(50)]
        public string varGrssprcntL { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        public int? intCompanyID { get; set; }
        public bool? isAllowSocialSecurity { get; set; }
    }
}
