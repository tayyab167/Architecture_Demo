using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAgreement
    {
        [Key]
        public int intSeqId { get; set; }
        public string varAgreement { get; set; }
        [StringLength(150)]
        public string varDepartmentId { get; set; }
        [StringLength(150)]
        public string varBranchId { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(250)]
        public string varDepartmentName { get; set; }
        [StringLength(250)]
        public string varBranchName { get; set; }
        [StringLength(250)]
        public string varTitle { get; set; }
        public int? isNDA { get; set; }
        public int? isContract { get; set; }
    }
}
