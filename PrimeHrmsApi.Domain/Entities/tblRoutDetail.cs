using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblRoutDetail
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intMasterID { get; set; }
        [StringLength(2000)]
        public string varStopName { get; set; }
        [StringLength(2000)]
        public string varLongitude { get; set; }
        [StringLength(2000)]
        public string varLatitude { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
    }
}
