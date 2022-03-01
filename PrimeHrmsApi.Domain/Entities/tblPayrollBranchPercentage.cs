using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPayrollBranchPercentage
    {
        public int? intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intBranchId { get; set; }
        public double? intPercentage { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationdate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatetionDate { get; set; }
        public int? intCompanyid { get; set; }
        public int? dtMonth { get; set; }
        public int? dtyear { get; set; }
    }
}
