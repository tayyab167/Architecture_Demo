﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class HRMS_company_New
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intEmployeeID { get; set; }
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [StringLength(200)]
        public string EOBIDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtMonth { get; set; }
        public int? IntCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intUpdatedID { get; set; }
        public int? intcompanyID { get; set; }
    }
}
