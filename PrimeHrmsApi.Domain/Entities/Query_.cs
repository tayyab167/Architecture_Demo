using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    [Table("Query$")]
    public partial class Query_
    {
        public double? intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTime { get; set; }
        public double? intEmployeeId { get; set; }
        public double? isMode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public double? intCompanyId { get; set; }
        [StringLength(255)]
        public string varType { get; set; }
        public double? intBranchId { get; set; }
        [StringLength(255)]
        public string varDeviceIp { get; set; }
        [StringLength(255)]
        public string varDeviceId { get; set; }
    }
}
