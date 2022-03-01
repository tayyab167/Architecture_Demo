using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeOnBoardingExperienceDetails
    {
        [Key]
        public int intSeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string companyName { get; set; }
        [Required]
        [StringLength(50)]
        public string designation { get; set; }
        [Column(TypeName = "date")]
        public DateTime fromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime toDate { get; set; }
        [Required]
        [StringLength(50)]
        public string contactNo { get; set; }
        [Required]
        [StringLength(500)]
        public string responsibilities { get; set; }
        [StringLength(200)]
        public string docs { get; set; }
        [Required]
        [StringLength(50)]
        public string linkKey { get; set; }
        public int companyNameS { get; set; }
        public int designationS { get; set; }
        public int fromDateS { get; set; }
        public int toDateS { get; set; }
        public int contactNoS { get; set; }
        public int responsibilitiesS { get; set; }
        public int docsS { get; set; }
        public int? overallS { get; set; }
        [StringLength(200)]
        public string DocsSalrySlip { get; set; }
    }
}
