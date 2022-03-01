using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblFuel
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intVehicalId { get; set; }
        public int? intDriveId { get; set; }
        public int? intMeterRead { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FuelDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FuelTime { get; set; }
        public int? intLiterNum { get; set; }
        public int? intperamountLiter { get; set; }
        public int? intTotalliter { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
