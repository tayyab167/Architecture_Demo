using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAttendanceLog
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTime { get; set; }
        public int? intEmployeeId { get; set; }
        public int? isMode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public int? intBranchId { get; set; }
        [StringLength(50)]
        public string varDeviceIp { get; set; }
        [StringLength(50)]
        public string varDeviceId { get; set; }
        public bool? isSaved { get; set; }
        public double? flLongitude { get; set; }
        public double? flLatitude { get; set; }
    }
}
