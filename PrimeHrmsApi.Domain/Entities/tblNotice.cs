using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblNotice
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(2000)]
        public string varComment { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? flTotalsend { get; set; }
        public int? inUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public bool? isEmail { get; set; }
        public int? intEmplyeeId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
