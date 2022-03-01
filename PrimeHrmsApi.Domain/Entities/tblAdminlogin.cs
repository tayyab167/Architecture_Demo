using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAdminlogin
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varUserName { get; set; }
        [StringLength(100)]
        public string varPassword { get; set; }
    }
}
