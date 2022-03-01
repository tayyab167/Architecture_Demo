using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeOnBoardingReasons
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(1000)]
        public string reason { get; set; }
        [Column(TypeName = "date")]
        public DateTime datePosted { get; set; }
        public int type { get; set; }
        public int arrayIndex { get; set; }
        [Required]
        [StringLength(200)]
        public string linkKey { get; set; }
    }
}
