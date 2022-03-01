using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOverTime
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intEmployeeId { get; set; }
        public double? flAmount { get; set; }
        public int? intOverTimeMints { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flPerMinuteSalary { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flOverTimeAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        public int? intBranchId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intDesignationId { get; set; }
        public bool? isProcess { get; set; }
        public bool? isPaid { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
