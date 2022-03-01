using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPerformanceTemplateDetail
    {
        public int? intSeqId { get; set; }
        public int? intMasterTemplateId { get; set; }
        public int? intIndicatorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedate { get; set; }
        public int? intUpdateBy { get; set; }
        public int? intCompanyid { get; set; }
    }
}
