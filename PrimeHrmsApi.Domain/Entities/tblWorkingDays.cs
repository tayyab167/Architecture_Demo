using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblWorkingDays
    {
        [Key]
        public int intSeqID { get; set; }
        public bool? isMonday { get; set; }
        public bool? isTuesday { get; set; }
        public bool? isWednesday { get; set; }
        public bool? isThursday { get; set; }
        public bool? isFriday { get; set; }
        public bool? isSaturday { get; set; }
        public bool? isSunday { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intBranchID { get; set; }
        public int? intDepartmentID { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public TimeSpan? dtSundayBreakStart { get; set; }
        public TimeSpan? dtSundayBreakEnd { get; set; }
        public TimeSpan? dtMondayBreakStart { get; set; }
        public TimeSpan? dtMondayBreakEnd { get; set; }
        public TimeSpan? dtTuesdayBreakStart { get; set; }
        public TimeSpan? dtTuesdayBreakEnd { get; set; }
        public TimeSpan? dtWednesdayBreakStart { get; set; }
        public TimeSpan? dtWednesdayBreakEnd { get; set; }
        public TimeSpan? dtThursdayBreakStart { get; set; }
        public TimeSpan? dtThursdayBreakEnd { get; set; }
        public TimeSpan? dtFridayBreakStart { get; set; }
        public TimeSpan? dtFridayBreakEnd { get; set; }
        public TimeSpan? dtSaturdayBreakStart { get; set; }
        public TimeSpan? dtSaturdayBreakEnd { get; set; }
        public TimeSpan? dtMonfrom { get; set; }
        public TimeSpan? dtMonto { get; set; }
        [StringLength(50)]
        public string dtMonBmin { get; set; }
        public TimeSpan? dtTuesfrom { get; set; }
        public TimeSpan? dtTuesto { get; set; }
        [StringLength(50)]
        public string dtTuesBmin { get; set; }
        public TimeSpan? dtWedFrom { get; set; }
        public TimeSpan? dtWedto { get; set; }
        [StringLength(50)]
        public string dtWedBmin { get; set; }
        public TimeSpan? dtThursFrom { get; set; }
        public TimeSpan? dtThursto { get; set; }
        [StringLength(50)]
        public string dtThursBmin { get; set; }
        public TimeSpan? dtFriFrom { get; set; }
        public TimeSpan? dtFrito { get; set; }
        [StringLength(50)]
        public string dtFriBmin { get; set; }
        public TimeSpan? dtSatFrom { get; set; }
        public TimeSpan? dtSatto { get; set; }
        [StringLength(50)]
        public string dtSatBmin { get; set; }
        public TimeSpan? dtSunFrom { get; set; }
        public TimeSpan? dtSunto { get; set; }
        [StringLength(50)]
        public string dtSunBmin { get; set; }
        [StringLength(50)]
        public string dtMonShiftAbb { get; set; }
        [StringLength(50)]
        public string dtTuesShiftAbb { get; set; }
        [StringLength(50)]
        public string dtWedShiftAbb { get; set; }
        [StringLength(50)]
        public string dtThursShiftAbb { get; set; }
        [StringLength(50)]
        public string dtFriShiftAbb { get; set; }
        [StringLength(50)]
        public string dtSatShiftAbb { get; set; }
        [StringLength(50)]
        public string dtSunShiftAbb { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWorkingHourMon { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWorkingHourTue { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWorkingHourWed { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWorkingHourThu { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWorkingHourFri { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWorkingHourSat { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? flWorkingHourSun { get; set; }
        public bool? chkMonExemption { get; set; }
        public bool? chkTueExemption { get; set; }
        public bool? chkWedExemption { get; set; }
        public bool? chkThuExemption { get; set; }
        public bool? chkFriExemption { get; set; }
        public bool? chkSatExemption { get; set; }
        public bool? chkSunExemption { get; set; }
        [StringLength(100)]
        public string flMonExeTitle { get; set; }
        [StringLength(100)]
        public string flTueExeTitle { get; set; }
        [StringLength(100)]
        public string flWedExeTitle { get; set; }
        [StringLength(100)]
        public string flThuExeTitle { get; set; }
        [StringLength(100)]
        public string flFriExeTitle { get; set; }
        [StringLength(100)]
        public string flSatExeTitle { get; set; }
        [StringLength(100)]
        public string flSunExeTitle { get; set; }
    }
}
