﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblProjectAssign
    {
        [Key]
        public int intSeqId { get; set; }
        public int? varProjectId { get; set; }
        public int? varCustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAsignDate { get; set; }
        [Key]
        public int intCompanyId { get; set; }
    }
}
