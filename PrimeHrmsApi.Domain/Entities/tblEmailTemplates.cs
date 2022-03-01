using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmailTemplates
    {
        public int? intSeqId { get; set; }
        [StringLength(50)]
        public string varTemplateName { get; set; }
        [Column(TypeName = "text")]
        public string varTemplateDesign { get; set; }
        public bool? isActive { get; set; }
        public int? intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? isInterview { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        [StringLength(150)]
        public string varEmailSubject { get; set; }
    }
}
