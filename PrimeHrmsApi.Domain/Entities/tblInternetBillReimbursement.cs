using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblInternetBillReimbursement
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intConnectionType { get; set; }
        [StringLength(500)]
        public string varInternetDescription { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intEmpID { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        [StringLength(500)]
        public string varAttachmentFile { get; set; }
        public int? intDepartmentId { get; set; }
        public int? intMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTimeStamp { get; set; }
        [StringLength(500)]
        public string varAdminRemarks { get; set; }
        public int? intYear { get; set; }
        public double? intAmount { get; set; }
        public int? intAdminEmpID { get; set; }
        public bool? isArpproved { get; set; }
    }
}
