using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAnnouncement
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(150)]
        public string varTitle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPublishDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtExpiryDate { get; set; }
        [StringLength(2000)]
        public string varDescription { get; set; }
        [StringLength(150)]
        public string intEmployeeId { get; set; }
        [StringLength(150)]
        public string intDepartmentId { get; set; }
        [StringLength(150)]
        public string intBranchId { get; set; }
        [StringLength(150)]
        public string intDesignationId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isEmailCheck { get; set; }
    }
}
