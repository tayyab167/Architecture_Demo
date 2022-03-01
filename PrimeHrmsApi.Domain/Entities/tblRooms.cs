﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblRooms
    {
        [Key]
        public int intSeqID { get; set; }
        [StringLength(50)]
        public string varRoomName { get; set; }
        [StringLength(50)]
        public string varAbbreviation { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        public int? intCapacity { get; set; }
        public double? flxAxis { get; set; }
        public double? flyAxis { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
    }
}