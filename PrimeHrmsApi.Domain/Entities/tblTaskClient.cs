using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaskClient
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(250)]
        public string varName { get; set; }
        public int? intProjectId { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intEmployeeId { get; set; }
        public bool? isShowAllTeamlead { get; set; }
    }
}
