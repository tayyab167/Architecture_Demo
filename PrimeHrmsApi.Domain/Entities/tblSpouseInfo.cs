using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSpouseInfo
    {
        public int IntSeqId { get; set; }
        public int IntCompanyId { get; set; }
        public int IntEmployeeId { get; set; }
        [StringLength(500)]
        public string varSpouseRelation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDOB { get; set; }
        [StringLength(2500)]
        public string varSpouseDescription { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtWedding { get; set; }
        [StringLength(150)]
        public string varSpouseSocialSecurity { get; set; }
        [StringLength(50)]
        public string varContactNo { get; set; }
        [StringLength(50)]
        public string varSpouseName { get; set; }
        public bool? chkNxtToKin { get; set; }
        [StringLength(100)]
        public string varEmail { get; set; }
        [StringLength(50)]
        public string varCNIC { get; set; }
        [StringLength(50)]
        public string varSuposeFName { get; set; }
        [StringLength(500)]
        public string varAddress { get; set; }
        public int? intSpouseAge { get; set; }
        [StringLength(100)]
        public string Gender { get; set; }
    }
}
