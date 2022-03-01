using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAlertsAndNotificationDays
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intPreviousBD { get; set; }
        public int? intComingBD { get; set; }
        public int? intPreviousJA { get; set; }
        public int? intComingJA { get; set; }
        public int? intPreviousCEnd { get; set; }
        public int? intComingCEnd { get; set; }
        public int? intPreviousPR { get; set; }
        public int? intComingPR { get; set; }
        public int? intPreviousPE { get; set; }
        public int? intComingPE { get; set; }
        public int? intComingNJ { get; set; }
        public int? intPreviousNJ { get; set; }
        public int? intPreviousEOBI { get; set; }
        public int? intComingEOBI { get; set; }
        public int? intPreviousInsurance { get; set; }
        public int? intComingInsurance { get; set; }
        public int? intPreviousJR { get; set; }
        public int? intComingJR { get; set; }
        public int? intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
    }
}
