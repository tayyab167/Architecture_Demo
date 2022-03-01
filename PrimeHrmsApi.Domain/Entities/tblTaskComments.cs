using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaskComments
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmpId { get; set; }
        public int? intTaskId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCommentDate { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public string varComment { get; set; }
    }
}
