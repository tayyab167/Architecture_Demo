using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpExit
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(300)]
        public string varDescription { get; set; }
        [StringLength(50)]
        public string varChecklistName { get; set; }
        public bool? isCompulsory { get; set; }
        public bool? isNeedDocument { get; set; }
        public int? intDeaprtmentID { get; set; }
        public int? intCreatedBy { get; set; }
        [StringLength(10)]
        public string dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(50)]
        public string dtUpdationDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchID { get; set; }
    }
}
