using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPOSRecipe
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intItemId { get; set; }
        public int? intUnitId { get; set; }
        [StringLength(50)]
        public string varQuantity { get; set; }
        [StringLength(50)]
        public string varRCost { get; set; }
        [StringLength(50)]
        public string flSaleQty { get; set; }
        [StringLength(50)]
        public string varCost { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int intOrderId { get; set; }
        public int? intLocId { get; set; }
        public int intCompanyId { get; set; }
    }
}
