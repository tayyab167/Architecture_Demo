using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCandidateCertification
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(1050)]
        public string varCertificate { get; set; }
        [StringLength(1050)]
        public string varInstitute { get; set; }
        public int? intYear { get; set; }
        public int? intCompanyId { get; set; }
        public int? intMasterID { get; set; }
    }
}
