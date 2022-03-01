using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblReservedBookMaster
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intStudentID { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
        public int? intCreatedBY { get; set; }
        public int? intModifiedBY { get; set; }
        public int? intIssuedBY { get; set; }
    }
}
