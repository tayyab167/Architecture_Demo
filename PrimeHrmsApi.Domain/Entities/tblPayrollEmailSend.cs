﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPayrollEmailSend
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmpId { get; set; }
        [StringLength(500)]
        public string varEmail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtSendDateTime { get; set; }
        public int? intMonth { get; set; }
        public int? intYear { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
