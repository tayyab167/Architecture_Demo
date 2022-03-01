using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblItems
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(500)]
        public string varName { get; set; }
        public string varDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationdate { get; set; }
        public int? intcompanyId { get; set; }
        public bool? isConsumeable { get; set; }
        public bool? isExpire { get; set; }
        public int? intCatId { get; set; }
        public int? intparentitemid { get; set; }
        [StringLength(500)]
        public string varItemCode { get; set; }
        public double? flQauntity { get; set; }
        public double? flQRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [StringLength(50)]
        public string varItemType { get; set; }
        public bool? isActive { get; set; }
    }
}
