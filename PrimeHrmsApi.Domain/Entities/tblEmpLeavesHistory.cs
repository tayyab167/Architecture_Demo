﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmpLeavesHistory
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intLeaveTypeId { get; set; }
        public int? intLeaveQouta { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intUsedLeave { get; set; }
        public int? intBalance { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        public int? intBranchId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLeaveStartPeriod { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtLeaveEndPeriod { get; set; }
    }
}
