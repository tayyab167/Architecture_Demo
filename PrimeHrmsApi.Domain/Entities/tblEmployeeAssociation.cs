using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeAssociation
    {
        public int IntSeqId { get; set; }
        public int? IntCompanyNameId { get; set; }
        public double? flPercentage { get; set; }
        public int? intBranchID { get; set; }
        [StringLength(50)]
        public string varEmployeeCode { get; set; }
        public int? IntDeparatmentId { get; set; }
        public int? IntDesignationId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCompanyId { get; set; }
    }
}
