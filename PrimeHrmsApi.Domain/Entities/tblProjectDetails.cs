using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblProjectDetails
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        public int? intProjectId { get; set; }
        [StringLength(100)]
        public string varWorkingHours { get; set; }
        [StringLength(100)]
        public string varRevisedHours { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [StringLength(100)]
        public string varClientApprovedHours { get; set; }
        public string varRemarks { get; set; }
        public bool? isProcess { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
