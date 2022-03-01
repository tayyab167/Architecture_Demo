using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeChild
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varName { get; set; }
        [StringLength(50)]
        public string varGender { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDOB { get; set; }
        [StringLength(100)]
        public string varCNIC { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intBranchID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intEmployeeId { get; set; }
    }
}
