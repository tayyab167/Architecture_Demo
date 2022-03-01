using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblParents
    {
        [Key]
        public int intSeqID { get; set; }
        [StringLength(500)]
        public string varFirstName { get; set; }
        [StringLength(500)]
        public string varLastName { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationdate { get; set; }
    }
}
