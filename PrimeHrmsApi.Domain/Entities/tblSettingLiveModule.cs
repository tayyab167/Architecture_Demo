using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblSettingLiveModule
    {
        [Key]
        public int intSeqid { get; set; }
        public bool? isLive { get; set; }
        public bool? isMulti { get; set; }
        [StringLength(50)]
        public string varLive { get; set; }
        [StringLength(50)]
        public string varMulti { get; set; }
        public bool? isSingle { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public bool? isShiftWise { get; set; }
        public bool? isShowIdMob { get; set; }
        public bool? isShowDepartMob { get; set; }
        public bool? isShowDesigMob { get; set; }
        public bool? isShowShifMob { get; set; }
    }
}
