using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblShiftMaster
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intDepartmentId { get; set; }
        [StringLength(200)]
        public string varShiftName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtShiftFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtShiftTo { get; set; }
        public int? intMasterShift { get; set; }
        [StringLength(200)]
        public string varDescription { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMonFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMonTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTueFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTueTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtWedFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtWedTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtThuFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtThuTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFriFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFriTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtSatFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtSatTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtSunFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtSunTo { get; set; }
        public bool? isTwoDates { get; set; }
    }
}
