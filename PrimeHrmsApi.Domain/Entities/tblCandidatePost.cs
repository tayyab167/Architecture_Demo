using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCandidatePost
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varFirstName { get; set; }
        [StringLength(50)]
        public string varLastName { get; set; }
        [StringLength(50)]
        public string varGender { get; set; }
        [StringLength(50)]
        public string varDateOfBirth { get; set; }
        [StringLength(250)]
        public string varAddress { get; set; }
        [StringLength(30)]
        public string varCity { get; set; }
        [StringLength(30)]
        public string varState { get; set; }
        [StringLength(50)]
        public string varPostalCode { get; set; }
        [StringLength(50)]
        public string varCountry { get; set; }
        [StringLength(100)]
        public string varEmail { get; set; }
        [StringLength(50)]
        public string varPhoneNumber { get; set; }
        public string varInterests { get; set; }
        public string varAchivements { get; set; }
        public int? intExperience { get; set; }
        public int? intJobPost { get; set; }
        public int? intStatusId { get; set; }
        public int? intCompanyId { get; set; }
        public string pdfCv { get; set; }
        [StringLength(150)]
        public string varCandidateCompany { get; set; }
        [StringLength(150)]
        public string varUniversityName { get; set; }
        [StringLength(150)]
        public string varQualification { get; set; }
        [StringLength(1000)]
        public string varTagList { get; set; }
        public bool? isAdmin { get; set; }
        [StringLength(50)]
        public string varPostApplying { get; set; }
        public int? intExpectedSalary { get; set; }
        public int? intCurrentSalary { get; set; }
        [StringLength(50)]
        public string varCNIC { get; set; }
        public int? intReligion { get; set; }
        [StringLength(50)]
        public string varMaritalStatus { get; set; }
        public int? intAge { get; set; }
        public int? intBloodGroup { get; set; }
        [StringLength(150)]
        public string varFOccupation { get; set; }
        [StringLength(50)]
        public string varDependents { get; set; }
        [StringLength(50)]
        public string varPTCL { get; set; }
        [StringLength(150)]
        public string varTempAddress { get; set; }
        [StringLength(250)]
        public string varImagePath { get; set; }
        public int? intEmployeeType { get; set; }
        [StringLength(50)]
        public string varSkypeID { get; set; }
        [StringLength(2500)]
        public string varPortfolio { get; set; }
        [StringLength(1050)]
        public string varCoverLetter { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtExpectJoiningDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtActualJoiningDate { get; set; }
        public bool? isRejectedByCandidate { get; set; }
        [StringLength(500)]
        public string varShortListedComments { get; set; }
        [StringLength(50)]
        public string varName1 { get; set; }
        [StringLength(100)]
        public string varEmail1 { get; set; }
        [StringLength(50)]
        public string varphone1 { get; set; }
        public int? varjobpost { get; set; }
        public string varfile { get; set; }
    }
}
