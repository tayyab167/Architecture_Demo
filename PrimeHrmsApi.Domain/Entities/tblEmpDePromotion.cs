using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpDePromotion
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intFromDesignationId { get; set; }
        public int? intToDesignationId { get; set; }
        [StringLength(100)]
        public string varType { get; set; }
        public bool? isApproved { get; set; }
        public int? intApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovalDate { get; set; }
        [StringLength(300)]
        public string varApprovalDescription { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
