using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPerformanceAppraisalMailMaster
    {
        [Key]
        public int intSeqid { get; set; }
        public int? intEmployeeid { get; set; }
        public int? intClientid { get; set; }
        public int? intManageID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public bool? isstatus { get; set; }
        public int? intFilledBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtfilledDate { get; set; }
        public int? intSendTo { get; set; }
        public bool? isKpi { get; set; }
        [StringLength(500)]
        public string varKpivalue { get; set; }
        [StringLength(50)]
        public string varReverterName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtRevertDate { get; set; }
        [Key]
        public int intCompanyid { get; set; }
        public bool? isEmpAccepted { get; set; }
        [StringLength(50)]
        public string varMonth { get; set; }
        [StringLength(50)]
        public string varYear { get; set; }
        public double? flObtainedMarks { get; set; }
        public int? intBranchId { get; set; }
        public int? intDepId { get; set; }
        public int? isShowPrevious { get; set; }
        public int? intMasterId { get; set; }
        public int? intP1Id { get; set; }
        public int? intP2Id { get; set; }
        public int? intP3Id { get; set; }
        public int? intP4Id { get; set; }
        public int? intP5Id { get; set; }
        public int? intP6Id { get; set; }
        public double? intPuntuality { get; set; }
        [StringLength(2050)]
        public string varHistory { get; set; }
        public double? flLastIncrement { get; set; }
        [StringLength(2050)]
        public string varManagerPDFeedBack { get; set; }
        public double? sugestedPercentage { get; set; }
        public double? inCrementPKR { get; set; }
        public double? SalaryAdditiveAllowance { get; set; }
        public double? TotalIncrementAmount { get; set; }
        public double? intCrementedAmount { get; set; }
        [StringLength(2050)]
        public string FinalRemarks { get; set; }
        public double? OverAllWeight { get; set; }
        public double? SALink { get; set; }
        public double? TLLink { get; set; }
        public double? AdjusmentAmountCheck { get; set; }
        public double? flTotalSelfPercentage { get; set; }
        public int? intSuggestedPercentage { get; set; }
        public double? flTotalSelfPercentageQuarterly { get; set; }
        public double? flTotalIcrementAmountNotSalary { get; set; }
        public int? intFlowManagerId { get; set; }
    }
}
