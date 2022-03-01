using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDriverManagement
    {
        [Key]
        public int intSeqID { get; set; }
        [StringLength(50)]
        public string varDriverName { get; set; }
        public int? intAge { get; set; }
        [StringLength(50)]
        public string varAddress { get; set; }
        [StringLength(50)]
        public string varCity { get; set; }
        [StringLength(50)]
        public string varState { get; set; }
        [StringLength(50)]
        public string varPostalCode { get; set; }
        [StringLength(50)]
        public string varCellNo { get; set; }
        [StringLength(50)]
        public string varPhone { get; set; }
        [StringLength(50)]
        public string varNTN { get; set; }
        [StringLength(50)]
        public string varLicenseNo { get; set; }
        [StringLength(50)]
        public string varPassportNo { get; set; }
        public int? intExperience { get; set; }
        [StringLength(50)]
        public string varLastJobEmployer { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
    }
}
