using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblOverTimeRequestDetail
    {
        public int intSeqId { get; set; }
        [StringLength(20)]
        public string dtStartDate { get; set; }
        [StringLength(20)]
        public string dtEndDate { get; set; }
        [StringLength(20)]
        public string dtStartTime { get; set; }
        [StringLength(20)]
        public string dtEndTime { get; set; }
        [StringLength(20)]
        public string intWorkingHours { get; set; }
        public double? intApprovedHours { get; set; }
        public double? intHourlyRate { get; set; }
        [StringLength(20)]
        public string intAmountDetail { get; set; }
        [StringLength(20)]
        public string intOrderNo { get; set; }
        [StringLength(200)]
        public string varDescriptionDetail { get; set; }
        public int? intMasteridOvertime { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationdate { get; set; }
        public int? intEmployeeId { get; set; }
    }
}
