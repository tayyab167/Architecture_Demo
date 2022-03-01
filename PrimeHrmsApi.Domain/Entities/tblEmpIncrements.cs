using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpIncrements
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(100)]
        public string varType { get; set; }
        public double? flAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEffectFromDate { get; set; }
        [Key]
        public int intComapnyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
