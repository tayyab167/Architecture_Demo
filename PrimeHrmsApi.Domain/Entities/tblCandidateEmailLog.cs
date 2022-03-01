using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCandidateEmailLog
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intCandidateID { get; set; }
        public int? intStatusID { get; set; }
        [StringLength(250)]
        public string varSubject { get; set; }
        public string varBody { get; set; }
        [StringLength(500)]
        public string varTo { get; set; }
        [StringLength(150)]
        public string varCV { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public int? intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
