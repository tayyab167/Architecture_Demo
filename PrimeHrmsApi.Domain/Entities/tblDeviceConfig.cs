using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDeviceConfig
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(100)]
        public string varLiscence { get; set; }
        [StringLength(100)]
        public string varMachine { get; set; }
        [StringLength(100)]
        public string varDeviceIP { get; set; }
        [StringLength(100)]
        public string varDeviceName { get; set; }
        [StringLength(100)]
        public string varPort { get; set; }
        [StringLength(100)]
        public string varRefreshTime { get; set; }
        [StringLength(100)]
        public string varTimeOut { get; set; }
        [StringLength(100)]
        public string varDevicePassword { get; set; }
        [StringLength(100)]
        public string varServerIP { get; set; }
        [StringLength(100)]
        public string varDatabase { get; set; }
        [StringLength(100)]
        public string varServerUser { get; set; }
        [StringLength(100)]
        public string varServerPassword { get; set; }
        [StringLength(200)]
        public string varValidationKey { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
        public int? intBranchId { get; set; }
        [StringLength(50)]
        public string varMachineId { get; set; }
        [StringLength(50)]
        public string varTimeZone { get; set; }
    }
}
