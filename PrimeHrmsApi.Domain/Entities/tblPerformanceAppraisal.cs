using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPerformanceAppraisal
    {
        [Key]
        public int intSeqId { get; set; }
        public string varTitle { get; set; }
        public string varDescription { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public bool? isMenual { get; set; }
        public bool? isShowDescription { get; set; }
        public bool? isDoubleColumn { get; set; }
        public int? intParentId { get; set; }
    }
}
