using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTravelExpenseDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTravelDate { get; set; }
        [StringLength(50)]
        public string varTravelFrom { get; set; }
        [StringLength(50)]
        public string varTravelTo { get; set; }
        public double? flAmount { get; set; }
        [StringLength(500)]
        public string varDetails { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
