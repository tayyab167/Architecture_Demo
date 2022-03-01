using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLoanRequest
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmpId { get; set; }
        [StringLength(150)]
        public string varBranchId { get; set; }
        [StringLength(350)]
        public string varDepartmentId { get; set; }
        [StringLength(350)]
        public string varDesignationId { get; set; }
        [StringLength(350)]
        public string varEmpIoyeeId { get; set; }
        [StringLength(1000)]
        public string varDescription { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
