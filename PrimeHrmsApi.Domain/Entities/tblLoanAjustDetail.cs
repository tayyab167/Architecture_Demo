using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLoanAjustDetail
    {
        public int? intSeqId { get; set; }
        [StringLength(50)]
        public string TotalbalAdjust { get; set; }
        public int? dtMonth { get; set; }
        public int? dtyear { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateionDate { get; set; }
        public int? intUpdateby { get; set; }
        public int? intCompanyid { get; set; }
        public int? TotalLoan { get; set; }
        public int? intLoanDeduct { get; set; }
        public int? totalRemainingBalance { get; set; }
        public int? intMasterLoanId { get; set; }
        public int? intEmployeeId { get; set; }
    }
}
