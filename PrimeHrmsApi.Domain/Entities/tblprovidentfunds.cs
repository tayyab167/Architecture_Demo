using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblprovidentfunds
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string intEmpApllicable { get; set; }
        [StringLength(50)]
        public string intCompApplicable { get; set; }
        [StringLength(50)]
        public string varEmpContMonth { get; set; }
        [StringLength(50)]
        public string varCompContMonth { get; set; }
        public bool? isEnable { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public bool? isAllowEmpPF { get; set; }
        public bool? isAllowComPF { get; set; }
        [StringLength(50)]
        public string varEmpPFdt { get; set; }
        [StringLength(50)]
        public string varComPFdt { get; set; }
        public bool? isHideComPFAfterOneYear { get; set; }
        public bool? isCheckEmpStatus { get; set; }
    }
}
