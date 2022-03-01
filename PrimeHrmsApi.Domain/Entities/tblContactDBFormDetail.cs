using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblContactDBFormDetail
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intMasterId { get; set; }
        public int? intCompanyid { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationdate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        [StringLength(250)]
        public string varEmployeeName { get; set; }
        [StringLength(250)]
        public string varCellNo { get; set; }
        [StringLength(250)]
        public string varEmailId { get; set; }
        [StringLength(250)]
        public string varExtNo { get; set; }

        [ForeignKey(nameof(intMasterId))]
        [InverseProperty(nameof(tblContactDBFormMaster.tblContactDBFormDetail))]
        public virtual tblContactDBFormMaster intMaster { get; set; }
    }
}
