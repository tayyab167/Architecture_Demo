﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEssNotification
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(100)]
        public string dtCreationDate { get; set; }
        [StringLength(100)]
        public string dtUpdationDate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        public bool? isAllowPublish { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtPublishDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtEndDate { get; set; }
        [StringLength(500)]
        public string varDescription { get; set; }
    }
}
