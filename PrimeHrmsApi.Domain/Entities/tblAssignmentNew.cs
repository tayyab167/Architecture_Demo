using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAssignmentNew
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intVehicalId { get; set; }
        public int? intDriverId { get; set; }
        [StringLength(50)]
        public string intStation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtfromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtTodate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dttimedeparture { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dttimearrival { get; set; }
        public int? intMeterstart { get; set; }
        public int? intMeterEnd { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        [StringLength(50)]
        public string varPersonsName { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
    }
}
