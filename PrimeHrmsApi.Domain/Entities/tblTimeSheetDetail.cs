using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTimeSheetDetail
    {
        [Key]
        public int intSeqId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intTimeSheetId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtWorkDate { get; set; }
        public double? flBalanceHours { get; set; }
        public double? flAllocatedHours { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        public int? intApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtApprovedDate { get; set; }
        public int? intAuthorizedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAuthorizedDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
    }
}
