using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblNumbers
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varNumber { get; set; }
        [StringLength(50)]
        public string varGroup { get; set; }
        [StringLength(50)]
        public string varPerson { get; set; }
    }
}
