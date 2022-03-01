using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLeaveEncashment
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBY { get; set; }
        public int? intCompanyId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intLeaveTypeId { get; set; }
        [StringLength(50)]
        public string varDaysEncashment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public double? flDaysEncashGross { get; set; }
    }
}
