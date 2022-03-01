using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblQuotationAdminM
    {
        [Key]
        public int intSeqid { get; set; }
        [StringLength(50)]
        public string varName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [StringLength(50)]
        public string varQNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtValidDate { get; set; }
        [StringLength(50)]
        public string varPaymentMethod { get; set; }
        public int? intItems { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? nuAmount { get; set; }
        [StringLength(50)]
        public string varAttachement { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
    }
}
