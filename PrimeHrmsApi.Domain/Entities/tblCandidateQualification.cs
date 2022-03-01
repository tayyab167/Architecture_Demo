using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCandidateQualification
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterID { get; set; }
        public int? intDegree { get; set; }
        [StringLength(250)]
        public string varUniversity { get; set; }
        [StringLength(50)]
        public string varMajor { get; set; }
        public int? intPassingYear { get; set; }
        [StringLength(50)]
        public string varGPAGrade { get; set; }
        public int? intMarks { get; set; }
        public int? intCompanyID { get; set; }
    }
}
