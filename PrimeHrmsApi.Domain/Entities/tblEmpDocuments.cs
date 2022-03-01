using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpDocuments
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intDocCatId { get; set; }
        [StringLength(100)]
        public string varDocName { get; set; }
        [StringLength(200)]
        public string varDocDetail { get; set; }
        public bool? isExpiry { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtExpiryDate { get; set; }
        [StringLength(300)]
        public string varPath { get; set; }
        [StringLength(100)]
        public string varPassword { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(50)]
        public string varfileNo { get; set; }
        [StringLength(100)]
        public string varType { get; set; }
    }
}
