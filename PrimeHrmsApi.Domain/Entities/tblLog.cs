﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLog
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intEmployeeId { get; set; }
        [StringLength(1000)]
        public string varEvent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEventDate { get; set; }
        [StringLength(500)]
        public string varStatus { get; set; }
        [StringLength(50)]
        public string varRecordId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intBranchId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}