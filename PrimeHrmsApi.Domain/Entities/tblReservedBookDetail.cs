using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblReservedBookDetail
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intMasterID { get; set; }
        public int? intBookID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtReservedFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtReservedTo { get; set; }
        public string varDescription { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBY { get; set; }
        public int? intModifiedBY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModification { get; set; }
    }
}
