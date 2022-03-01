using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class vwGetLeavesDetail
    {
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        public int intCompanyId { get; set; }
        public bool? isPaid { get; set; }
        [StringLength(3000)]
        public string varReason { get; set; }
        [Column(TypeName = "numeric(38, 2)")]
        public decimal LCount { get; set; }
    }
}
