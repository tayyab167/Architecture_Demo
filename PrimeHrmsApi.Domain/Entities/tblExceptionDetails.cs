using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblExceptionDetails
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(3000)]
        public string varPageName { get; set; }
        [StringLength(4000)]
        public string varException { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intCompanyId { get; set; }
        public int? intUserId { get; set; }
    }
}
