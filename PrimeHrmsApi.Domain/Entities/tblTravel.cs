using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblTravel
    {
        [Key]
        public int intSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        [StringLength(50)]
        public string TravelCost { get; set; }
        [StringLength(50)]
        public string varlocation { get; set; }
        [StringLength(50)]
        public string varMeal { get; set; }
        [StringLength(50)]
        public string varMedium { get; set; }
        [StringLength(50)]
        public string varResidence { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationdate { get; set; }
        [StringLength(50)]
        public string varOther { get; set; }
        [StringLength(500)]
        public string varTravelDescription { get; set; }
        [StringLength(500)]
        public string varMealDescription { get; set; }
        [StringLength(500)]
        public string varResidenceDescription { get; set; }
        [StringLength(500)]
        public string varOtherDescription { get; set; }
    }
}
