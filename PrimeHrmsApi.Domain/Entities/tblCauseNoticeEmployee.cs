using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCauseNoticeEmployee
    {
        public int? intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intDesignationId { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intCreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreateDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intCauseNoticeId { get; set; }
    }
}
