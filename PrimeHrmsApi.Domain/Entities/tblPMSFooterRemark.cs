using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSFooterRemark
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public bool? isAllowCustomC1 { get; set; }
        [StringLength(50)]
        public string varCustomC1Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC1Name { get; set; }
        public bool? isAllowCustomC2 { get; set; }
        [StringLength(50)]
        public string varCustomC2Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC2Name { get; set; }
        public bool? isAllowCustomC3 { get; set; }
        [StringLength(50)]
        public string varCustomC3Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC3Name { get; set; }
        public bool? isAllowCustomC4 { get; set; }
        [StringLength(50)]
        public string varCustomC4Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC4Name { get; set; }
        public bool? isAllowCustomC5 { get; set; }
        [StringLength(50)]
        public string varCustomC5Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC5Name { get; set; }
        public bool? isAllowCustomC6 { get; set; }
        [StringLength(50)]
        public string varCustomC6Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC6Name { get; set; }
        public bool? isAllowCustomC7 { get; set; }
        [StringLength(50)]
        public string varCustomC7Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC7Name { get; set; }
        public bool? isAllowCustomC8 { get; set; }
        [StringLength(50)]
        public string varCustomC8Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC8Name { get; set; }
        public bool? isAllowCustomC9 { get; set; }
        [StringLength(50)]
        public string varCustomC9Remarks { get; set; }
        [StringLength(50)]
        public string varCustomC9Name { get; set; }
    }
}
