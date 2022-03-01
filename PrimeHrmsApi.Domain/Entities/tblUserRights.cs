using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblUserRights
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intUserId { get; set; }
        public int? intPageId { get; set; }
        [StringLength(50)]
        public string varPageName { get; set; }
        public bool? isControl { get; set; }
        public bool? isAdd { get; set; }
        public bool? isEdit { get; set; }
        public bool? isDelete { get; set; }
        public bool? isSearch { get; set; }
        public int? intActionBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intBranchId { get; set; }
    }
}
