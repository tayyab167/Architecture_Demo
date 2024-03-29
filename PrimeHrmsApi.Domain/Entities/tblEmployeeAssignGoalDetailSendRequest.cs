﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblEmployeeAssignGoalDetailSendRequest
    {
        public int? intSeqId { get; set; }
        public int? intMasterId { get; set; }
        public int? intObjectiveId { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationdate { get; set; }
        public int? intCompanyid { get; set; }
        public double? intMarksRating { get; set; }
        public int? intManageId { get; set; }
        [StringLength(50)]
        public string varRemarksGoals { get; set; }
        public int? intSetid { get; set; }
        public int? intEmployeeId { get; set; }
        public int? intSendTo { get; set; }
        public bool? isSubmit { get; set; }
    }
}
