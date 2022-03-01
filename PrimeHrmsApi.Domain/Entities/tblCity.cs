﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblCity
    {
        [Key]
        [StringLength(200)]
        public string varCountry { get; set; }
        [Key]
        [StringLength(150)]
        public string varState { get; set; }
        [Key]
        [StringLength(100)]
        public string varCity { get; set; }
    }
}