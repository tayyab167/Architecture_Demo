using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class viewStock
    {
        public int? intCompanyId { get; set; }
        public int itemid { get; set; }
        [StringLength(50)]
        public string viewvartype { get; set; }
        [StringLength(50)]
        public string viewvarInvenType { get; set; }
        public double? qty { get; set; }
        [Required]
        [StringLength(8)]
        public string abc { get; set; }
    }
}
