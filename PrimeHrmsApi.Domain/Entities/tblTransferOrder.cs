using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTransferOrder
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeID { get; set; }
        [StringLength(150)]
        public string varEmpName { get; set; }
        [StringLength(150)]
        public string varFatherName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtJoinDate { get; set; }
        public int? intOLDDesignationID { get; set; }
        public int? intOLDParentDepID { get; set; }
        public int? intOLDsubDepID { get; set; }
        public int? intOldSectiion { get; set; }
        public int? intShiftID { get; set; }
        public int? intNewDesignationID { get; set; }
        public int? intNewParentDepID { get; set; }
        public int? intNewSubDepartID { get; set; }
        public int? intNewSectionID { get; set; }
        public int? intNewShiftID { get; set; }
        public int? intCompanyID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(50)]
        public string varStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtWEFDate { get; set; }
        public double? flSalaryOld { get; set; }
        public double? flSalaryNew { get; set; }
        public int? intReportedToOLD { get; set; }
        public int? intReportedToNew { get; set; }
        public int? intManagerIdOLD { get; set; }
        public int? intManagerIdNew { get; set; }
    }
}
