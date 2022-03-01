using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAttendanceLeaveSummary_Report
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intUserId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Designation { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [Column("Employee Status")]
        [StringLength(50)]
        public string Employee_Status { get; set; }
        [Column("Leave Late Ded")]
        [StringLength(50)]
        public string Leave_Late_Ded { get; set; }
        [Column("Early Ded")]
        [StringLength(50)]
        public string Early_Ded { get; set; }
        [Column("Missing Ded")]
        [StringLength(50)]
        public string Missing_Ded { get; set; }
        [StringLength(50)]
        public string Absent { get; set; }
        [StringLength(50)]
        public string PaidDays { get; set; }
        [StringLength(20)]
        public string LT1_Availed { get; set; }
        [StringLength(20)]
        public string LT2_Availed { get; set; }
        [StringLength(20)]
        public string LT3_Availed { get; set; }
        [StringLength(20)]
        public string LT4_Availed { get; set; }
        [StringLength(20)]
        public string LT5_Availed { get; set; }
        [StringLength(20)]
        public string LT6_Availed { get; set; }
        [StringLength(20)]
        public string LT7_Availed { get; set; }
        [StringLength(20)]
        public string LT8_Availed { get; set; }
        [StringLength(20)]
        public string LT9_Availed { get; set; }
        [StringLength(20)]
        public string LT10_Availed { get; set; }
        [StringLength(20)]
        public string LT11_Availed { get; set; }
        [StringLength(20)]
        public string LT12_Availed { get; set; }
        [StringLength(20)]
        public string LT13_Availed { get; set; }
        [StringLength(20)]
        public string LT14_Availed { get; set; }
        [StringLength(20)]
        public string LT15_Availed { get; set; }
        [StringLength(20)]
        public string LT16_Availed { get; set; }
        [StringLength(20)]
        public string LT17_Availed { get; set; }
        [StringLength(20)]
        public string LT1_Bal { get; set; }
        [StringLength(20)]
        public string LT2_Bal { get; set; }
        [StringLength(20)]
        public string LT3_Bal { get; set; }
        [StringLength(20)]
        public string LT4_Bal { get; set; }
        [StringLength(20)]
        public string LT5_Bal { get; set; }
        [StringLength(20)]
        public string LT6_Bal { get; set; }
        [StringLength(20)]
        public string LT7_Bal { get; set; }
        [StringLength(20)]
        public string LT8_Bal { get; set; }
        [StringLength(20)]
        public string LT9_Bal { get; set; }
        [StringLength(20)]
        public string LT10_Bal { get; set; }
        [StringLength(20)]
        public string LT11_Bal { get; set; }
        [StringLength(20)]
        public string LT12_Bal { get; set; }
        [StringLength(20)]
        public string LT13_Bal { get; set; }
        [StringLength(20)]
        public string LT14_Bal { get; set; }
        [StringLength(20)]
        public string LT15_Bal { get; set; }
        [StringLength(20)]
        public string LT16_Bal { get; set; }
        [StringLength(20)]
        public string LT17_Bal { get; set; }
    }
}
