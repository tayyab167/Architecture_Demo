﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAttendanceEmailLog
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varEmailTo { get; set; }
        [StringLength(50)]
        public string varEmailFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEmailTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string varType { get; set; }
    }
}
