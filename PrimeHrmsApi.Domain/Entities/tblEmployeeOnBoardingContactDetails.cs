using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeOnBoardingContactDetails
    {
        [Key]
        public int intSeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string contactType { get; set; }
        [Required]
        [StringLength(50)]
        public string city { get; set; }
        [Required]
        [StringLength(50)]
        public string phoneNo { get; set; }
        [Required]
        [StringLength(50)]
        public string state { get; set; }
        [Required]
        [StringLength(50)]
        public string cellNo { get; set; }
        [Required]
        [StringLength(50)]
        public string fax { get; set; }
        [Required]
        [StringLength(400)]
        public string address { get; set; }
        [Required]
        [StringLength(50)]
        public string linkKey { get; set; }
        public int contactTypeS { get; set; }
        public int cityS { get; set; }
        public int phoneNoS { get; set; }
        public int stateS { get; set; }
        public int cellNoS { get; set; }
        public int faxS { get; set; }
        public int addressS { get; set; }
        public int? overallS { get; set; }
    }
}
