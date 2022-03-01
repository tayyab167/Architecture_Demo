using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDaysIndicatorDetail
    {
        [Key]
        public int intSeqId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intMasterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intIndicatorPresent { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? intIndicatorAbsent { get; set; }
        public int? intDepartmentId { get; set; }
    }
}
