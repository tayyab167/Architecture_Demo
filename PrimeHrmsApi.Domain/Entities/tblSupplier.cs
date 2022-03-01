using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSupplier
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(100)]
        public string varName { get; set; }
        [StringLength(100)]
        public string varFname { get; set; }
        [StringLength(200)]
        public string varAddress1 { get; set; }
        [StringLength(50)]
        public string varMobile1 { get; set; }
        [StringLength(50)]
        public string varPhone1 { get; set; }
        [StringLength(100)]
        public string varAddress2 { get; set; }
        [StringLength(50)]
        public string varMobile2 { get; set; }
        [StringLength(50)]
        public string varPhone2 { get; set; }
        [StringLength(100)]
        public string varAddress3 { get; set; }
        [StringLength(50)]
        public string varMobile3 { get; set; }
        [StringLength(50)]
        public string varPhone3 { get; set; }
        [StringLength(50)]
        public string varCity { get; set; }
        [StringLength(500)]
        public string varNotes { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        [StringLength(50)]
        public string varCNIC { get; set; }
        public bool? isActive { get; set; }
        [StringLength(50)]
        public string intSalesTaxNo { get; set; }
        [StringLength(50)]
        public string intNtnNo { get; set; }
        [StringLength(100)]
        public string varContactPerson1 { get; set; }
        [StringLength(100)]
        public string varContactPerson2 { get; set; }
        [StringLength(100)]
        public string varDesignation1 { get; set; }
        [StringLength(100)]
        public string varDesignation { get; set; }
        [StringLength(20)]
        public string varContactNo1 { get; set; }
        [StringLength(20)]
        public string varContactNo2 { get; set; }
        [StringLength(50)]
        public string varPaymentTerms { get; set; }
        [StringLength(50)]
        public string varYIB { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flCrLimit { get; set; }
        public bool? isBillable { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtOpeningDate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flOpeningBalance { get; set; }
        public int? intMachineId { get; set; }
        [StringLength(50)]
        public string varAccountno { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMachineCreation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMachineUpdation { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        [StringLength(150)]
        public string varDonorType { get; set; }
        [StringLength(50)]
        public string varReference { get; set; }
        [StringLength(50)]
        public string varCountry { get; set; }
        [StringLength(50)]
        public string varState { get; set; }
        public bool? isQualified { get; set; }
        [StringLength(50)]
        public string file1 { get; set; }
        [StringLength(50)]
        public string file2 { get; set; }
        [StringLength(50)]
        public string file3 { get; set; }
        [StringLength(50)]
        public string file4 { get; set; }
        [StringLength(50)]
        public string file5 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtSubmissiondate { get; set; }
        [StringLength(200)]
        public string varCompanySpeciality { get; set; }
        [StringLength(50)]
        public string varDesFile1 { get; set; }
        [StringLength(50)]
        public string varDesFile2 { get; set; }
        [StringLength(50)]
        public string varDesFile3 { get; set; }
        [StringLength(50)]
        public string varDesFile4 { get; set; }
        [StringLength(50)]
        public string varDesFile5 { get; set; }
    }
}
