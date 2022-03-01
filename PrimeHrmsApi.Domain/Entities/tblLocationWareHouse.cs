using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLocationWareHouse
    {
        [Key]
        public int intSeqID { get; set; }
        [StringLength(50)]
        public string varName { get; set; }
        public int? intLocationTypeId { get; set; }
        public int? intBranchId { get; set; }
        [StringLength(250)]
        public string varLocationCode { get; set; }
        [StringLength(80)]
        public string varAddress { get; set; }
        [StringLength(20)]
        public string varPhone { get; set; }
        [StringLength(30)]
        public string varContactPerson { get; set; }
        public int? intCreatedby { get; set; }
        public int? intUpdateby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public bool? isActive { get; set; }
        [StringLength(50)]
        public string varAbbrivation { get; set; }
        [StringLength(50)]
        public string varAccount { get; set; }
        public int? intCompanyId { get; set; }
    }
}
