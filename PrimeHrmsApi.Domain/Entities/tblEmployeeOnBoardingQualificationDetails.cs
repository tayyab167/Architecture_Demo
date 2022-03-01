using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeOnBoardingQualificationDetails
    {
        [Key]
        public int intSeqId { get; set; }
        public int degreeId { get; set; }
        public int boardUni { get; set; }
        [Required]
        [StringLength(200)]
        public string boardName { get; set; }
        [Required]
        [StringLength(50)]
        public string passingYear { get; set; }
        [Required]
        [StringLength(50)]
        public string grade { get; set; }
        public double cgpa { get; set; }
        [StringLength(200)]
        public string docs { get; set; }
        [Required]
        [StringLength(100)]
        public string linkKey { get; set; }
        public int degreeNameS { get; set; }
        public int boardUniS { get; set; }
        public int passingYearS { get; set; }
        public int gradeS { get; set; }
        public int cgpaS { get; set; }
        public int docsS { get; set; }
        public int? overallS { get; set; }
    }
}
