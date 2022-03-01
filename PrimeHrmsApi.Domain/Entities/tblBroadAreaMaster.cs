using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblBroadAreaMaster
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToDate { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        public bool? isAvailedNextMonthTarget { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        [StringLength(50)]
        public string varMonth { get; set; }
        [StringLength(50)]
        public string varYear { get; set; }
        public int? intTaskGivenByManagerId { get; set; }
        [StringLength(400)]
        public string varPMSTypeWise { get; set; }
    }
}
