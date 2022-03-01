using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPreviousSchoolHistory
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intStudentID { get; set; }
        [StringLength(4000)]
        public string varSchoolName { get; set; }
        [StringLength(4000)]
        public string varAddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtJoinDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLeaveDate { get; set; }
        [StringLength(4000)]
        public string varClassName { get; set; }
        [StringLength(2000)]
        public string varGrade { get; set; }
        [StringLength(2000)]
        public string varStatus { get; set; }
        [StringLength(2000)]
        public string varPhone { get; set; }
        [StringLength(2000)]
        public string varEmailID { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intModifiedBY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
    }
}
