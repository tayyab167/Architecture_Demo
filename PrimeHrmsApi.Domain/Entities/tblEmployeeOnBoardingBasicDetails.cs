using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeOnBoardingBasicDetails
    {
        [Key]
        public int intSeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string empName { get; set; }
        [Column(TypeName = "date")]
        public DateTime dob { get; set; }
        [Required]
        [StringLength(50)]
        public string gender { get; set; }
        public int religion { get; set; }
        [Required]
        [StringLength(50)]
        public string mstatus { get; set; }
        [Required]
        [StringLength(50)]
        public string gardian { get; set; }
        [Required]
        [StringLength(50)]
        public string mblno { get; set; }
        [Required]
        [StringLength(100)]
        public string address { get; set; }
        [Required]
        [StringLength(50)]
        public string email { get; set; }
        [Required]
        [StringLength(50)]
        public string cnic { get; set; }
        [StringLength(50)]
        public string empImage { get; set; }
        [Required]
        [StringLength(50)]
        public string linkKey { get; set; }
        public int empNameS { get; set; }
        public int dobS { get; set; }
        public int genderS { get; set; }
        public int religionS { get; set; }
        public int mstatusS { get; set; }
        public int gardianS { get; set; }
        public int mblnoS { get; set; }
        public int addressS { get; set; }
        public int emailS { get; set; }
        public int cnicS { get; set; }
        public int empImageS { get; set; }
        public int? overAllS { get; set; }
        [StringLength(50)]
        public string empImageCNIC { get; set; }
        [StringLength(50)]
        public string EmpAccountNo { get; set; }
        [StringLength(50)]
        public string EmpbankName { get; set; }
        public int? empImageCNICS { get; set; }
        public int? EmpAccountNoS { get; set; }
        public int? EmpbankNameS { get; set; }
        public string EmpSignature { get; set; }
        public bool? isNDA { get; set; }
        public bool? isContract { get; set; }
    }
}
