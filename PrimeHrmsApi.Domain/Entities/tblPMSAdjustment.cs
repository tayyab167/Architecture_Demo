using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSAdjustment
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? fromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? toDate { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public double? flTotalMarksGiven { get; set; }
        public double? flAdjustment { get; set; }
    }
}
