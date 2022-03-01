using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDriver
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varDriverName { get; set; }
        [StringLength(50)]
        public string varParmntAddress { get; set; }
        [StringLength(50)]
        public string varConfrmAddress { get; set; }
        public int? intPhone1 { get; set; }
        public int? intPhone2 { get; set; }
        [StringLength(50)]
        public string varCNIC { get; set; }
        [StringLength(50)]
        public string vardriverlince { get; set; }
        public int? intGender { get; set; }
        [StringLength(50)]
        public string varBranch { get; set; }
        [StringLength(50)]
        public string varAttachfile1 { get; set; }
        [StringLength(50)]
        public string varAttachfile2 { get; set; }
        [StringLength(50)]
        public string varAttachfile3 { get; set; }
        [StringLength(50)]
        public string varAttachfile4 { get; set; }
        [StringLength(50)]
        public string varImage { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
