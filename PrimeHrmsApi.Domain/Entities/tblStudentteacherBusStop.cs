using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblStudentteacherBusStop
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intRoutID { get; set; }
        public int? intStopID { get; set; }
        public int? intStudentTeacherID { get; set; }
        [StringLength(500)]
        public string varType { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
        public int? intBusID { get; set; }
        [StringLength(200)]
        public string VarPickDrop { get; set; }
    }
}
