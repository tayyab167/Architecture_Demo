﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTaskProject
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(50)]
        public string varName { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intCreationBy { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCompanyId { get; set; }
        public bool? isActive { get; set; }
    }
}