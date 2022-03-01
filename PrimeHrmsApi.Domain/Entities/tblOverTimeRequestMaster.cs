using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOverTimeRequestMaster
    {
        public int intSeqId { get; set; }
        public int? intEmpID { get; set; }
        [StringLength(50)]
        public string intHourlyPerRate { get; set; }
        public int? intTotalHours { get; set; }
        public int? intApprovedHours { get; set; }
        [StringLength(50)]
        public string intTotalAmount { get; set; }
        [StringLength(200)]
        public string varDescriptionMaster { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(50)]
        public string varSupervisor { get; set; }
        [StringLength(50)]
        public string varDepartment { get; set; }
        [StringLength(50)]
        public string varDesignation { get; set; }
        public int? intMonth { get; set; }
        public int? intYear { get; set; }
        [StringLength(50)]
        public string varWorkingHours { get; set; }
    }
}
