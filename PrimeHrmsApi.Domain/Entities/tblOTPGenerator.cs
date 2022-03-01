using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOTPGenerator
    {
        [Key]
        public int intSeqID { get; set; }
        [StringLength(50)]
        public string varCNIC { get; set; }
        [StringLength(50)]
        public string varOTP { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtExpiryTime { get; set; }
        [StringLength(150)]
        public string varOTPFor { get; set; }
        public int? intCompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public bool? isUsed { get; set; }
    }
}
