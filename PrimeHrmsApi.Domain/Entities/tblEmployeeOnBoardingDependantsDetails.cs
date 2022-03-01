using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeOnBoardingDependantsDetails
    {
        [Key]
        public int intSeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string dependantName { get; set; }
        [Required]
        [StringLength(50)]
        public string relation { get; set; }
        [Column(TypeName = "date")]
        public DateTime dob { get; set; }
        [StringLength(50)]
        public string anniversaryDate { get; set; }
        [StringLength(50)]
        public string cellNo { get; set; }
        [StringLength(50)]
        public string email { get; set; }
        [StringLength(200)]
        public string docs { get; set; }
        [Required]
        [StringLength(50)]
        public string linkKey { get; set; }
        public int dependantNameS { get; set; }
        public int relationS { get; set; }
        public int dobS { get; set; }
        public int anniversaryDateS { get; set; }
        public int cellNoS { get; set; }
        public int emailS { get; set; }
        public int docsS { get; set; }
        public int? overallS { get; set; }
    }
}
