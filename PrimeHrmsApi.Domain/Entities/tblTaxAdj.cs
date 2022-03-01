using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaxAdj
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string Employee { get; set; }
        public int? Amount { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(50)]
        public string FileAttach { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationdate { get; set; }
        [StringLength(50)]
        public string Approval { get; set; }
        [StringLength(100)]
        public string ApprvDescription { get; set; }
    }
}
