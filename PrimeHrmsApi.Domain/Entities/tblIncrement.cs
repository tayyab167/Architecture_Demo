using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblIncrement
    {
        [Key]
        public int intSeqid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public int? intCompanyid { get; set; }
        public int? intEmployeeid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flSalary { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? flOldsalary { get; set; }
    }
}
