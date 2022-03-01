using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSIncrementHistory
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intPMSDateWiseIncrement { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCretionDate { get; set; }
        public double? flCurrentSalary { get; set; }
        public double? flNewSalary { get; set; }
        public bool? isApproved { get; set; }
        public int? intEmployeeId { get; set; }
    }
}
