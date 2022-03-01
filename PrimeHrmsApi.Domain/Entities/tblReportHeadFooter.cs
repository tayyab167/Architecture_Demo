using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblReportHeadFooter
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [StringLength(2000)]
        public string varOPDHeader { get; set; }
        [StringLength(4000)]
        public string varOPDBody { get; set; }
        [StringLength(2000)]
        public string varOPDFooter { get; set; }
        [StringLength(2000)]
        public string varEOBIHeader { get; set; }
        [StringLength(4000)]
        public string varEOBIBody { get; set; }
        [StringLength(2000)]
        public string varEOBIFooter { get; set; }
        [StringLength(2000)]
        public string varPFHeader { get; set; }
        [StringLength(4000)]
        public string varPFBody { get; set; }
        [StringLength(2000)]
        public string varPFFooter { get; set; }
        [StringLength(3000)]
        public string varExpenseHeader { get; set; }
        [StringLength(3000)]
        public string varExpenseFooter { get; set; }
    }
}
