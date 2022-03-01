using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblWishes
    {
        [Key]
        public int intSeqId { get; set; }
        public int intCompanyId { get; set; }
        public int intWishBy { get; set; }
        public int intWishTo { get; set; }
        [Required]
        [StringLength(100)]
        public string varWishType { get; set; }
        public bool? isDefaultcard { get; set; }
        [StringLength(250)]
        public string cardImageUrl { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtWishDate { get; set; }
    }
}
