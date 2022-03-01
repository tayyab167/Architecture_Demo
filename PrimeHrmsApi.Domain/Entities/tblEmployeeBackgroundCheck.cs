using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeBackgroundCheck
    {
        [Key]
        public int intSeqid { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCompanyID { get; set; }
        public int? intConductedBy { get; set; }
        public int? intEmployeeId { get; set; }
        public bool? isCNIC { get; set; }
        public bool? isReference { get; set; }
        public bool? isEducationalDoc { get; set; }
        public bool? isSalary { get; set; }
        public bool? isEmployeementHistoryDoc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtBgCheckDate { get; set; }
        [StringLength(1000)]
        public string varComments { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(500)]
        public string varFilePath { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? intUpdationDate { get; set; }
    }
}
