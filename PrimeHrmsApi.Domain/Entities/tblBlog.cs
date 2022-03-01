using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblBlog
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(2000)]
        public string varHeading { get; set; }
        public string varDescription { get; set; }
        [StringLength(500)]
        public string varImgPath { get; set; }
        [StringLength(500)]
        public string varCategory { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreation { get; set; }
        public int? intUpdatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdate { get; set; }
    }
}
