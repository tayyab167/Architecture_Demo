using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCategory
    {
        [Key]
        public int intseqid { get; set; }
        [StringLength(300)]
        public string varCategory { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
        public int? intCreatedby { get; set; }
        public int? intupdateby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? imgCategory { get; set; }
        [StringLength(500)]
        public string imagepath { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public int? intCompanyId { get; set; }
        public int? intParentCat { get; set; }
        public bool? isOperative { get; set; }
        [StringLength(50)]
        public string varCateCode { get; set; }
        [StringLength(50)]
        public string varParentCode { get; set; }
    }
}
