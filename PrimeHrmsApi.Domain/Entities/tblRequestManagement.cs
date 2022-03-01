using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblRequestManagement
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(1050)]
        public string varRequestTitle { get; set; }
        public int? intRequestType { get; set; }
        [StringLength(3050)]
        public string varDescription { get; set; }
        public int? intRequestedBy { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        public int? intRevision { get; set; }
        public bool? isDone { get; set; }
        public int? intRating { get; set; }
        public int? intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
