using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblFloaterLeave
    {
        public int intSeqId { get; set; }
        public int? FloaterEmpID { get; set; }
        public int? FloaterReportedTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        [StringLength(1000)]
        public string varDescription { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationdate { get; set; }
        public int? intCreatedBy { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        [StringLength(1000)]
        public string varRejectedReason { get; set; }
    }
}
