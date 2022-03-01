using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblProfit
    {
        [Key]
        public int IntSeqid { get; set; }
        public int? IntCompanyid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTodate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flTotalProfit { get; set; }
        public string varDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? IntCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public bool? IsProcessed { get; set; }
        public int? intEmployeeId { get; set; }
    }
}
