using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeItemAssign
    {
        [Key]
        public int intSeqid { get; set; }
        public int? intCatid { get; set; }
        public int? intItemid { get; set; }
        public int? intEmployeeId { get; set; }
        public double? flQauntity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? dtUpdatedBy { get; set; }
        public int? intCompanyid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
    }
}
