using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblStoreRestdaysOverTime
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate11 { get; set; }
        public int overTimeMinutes { get; set; }
        public int intEmpId { get; set; }
        public int intCompanyId { get; set; }
        public int intMonth { get; set; }
    }
}
