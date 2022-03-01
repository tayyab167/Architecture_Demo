using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblpublicHolidayMaster
    {
        [Key]
        public int intSeqID { get; set; }
        public string varName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        public bool? isAuto { get; set; }
        public bool? iaCustom { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public string varDescripton { get; set; }
        [StringLength(1)]
        public string varAbbrivation { get; set; }
        [Key]
        public int intCompanyID { get; set; }
    }
}
