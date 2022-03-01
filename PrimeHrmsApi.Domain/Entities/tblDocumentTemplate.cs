using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDocumentTemplate
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intDepartmentID { get; set; }
        [StringLength(50)]
        public string varDocName { get; set; }
        public bool? isCompulsary { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intBranchID { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
