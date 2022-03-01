using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblProjects
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intClientId { get; set; }
        public int? intCustomerId { get; set; }
        public int? intManagerId { get; set; }
        [StringLength(100)]
        public string varProjectName { get; set; }
        public string varDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        public bool? isActive { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
