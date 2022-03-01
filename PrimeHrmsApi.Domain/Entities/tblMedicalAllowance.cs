using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblMedicalAllowance
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public double? flAmount { get; set; }
        [StringLength(500)]
        public string varFilePath1 { get; set; }
        [StringLength(500)]
        public string varFilePath2 { get; set; }
        [StringLength(500)]
        public string varFilePath3 { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intMedicalPeriod { get; set; }
        public int? intMonth { get; set; }
        public bool? isAprvRej { get; set; }
        public bool? IsProcess { get; set; }
        public double? flOpening { get; set; }
        public int? intYear { get; set; }
    }
}
