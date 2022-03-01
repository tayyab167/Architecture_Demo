using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblStudent
    {
        [Key]
        public int intSeqID { get; set; }
        [StringLength(2000)]
        public string varFirstName { get; set; }
        [StringLength(2000)]
        public string varLastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? varDateOfBirth { get; set; }
        public int? intParentID { get; set; }
        [StringLength(2000)]
        public string varPhoneNo { get; set; }
        [StringLength(2000)]
        public string varEmailID { get; set; }
        [StringLength(2000)]
        public string varAddress1 { get; set; }
        [StringLength(2000)]
        public string varAddress2 { get; set; }
        public int? intCompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intMOdifiedBY { get; set; }
        [StringLength(500)]
        public string varImagePath { get; set; }
    }
}
