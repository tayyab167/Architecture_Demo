﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblFAQSetup
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string varQuestion { get; set; }
        [StringLength(200)]
        public string varAnswer { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
    }
}
