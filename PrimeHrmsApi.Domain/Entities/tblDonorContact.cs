using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblDonorContact
    {
        [Key]
        public int intSeqId { get; set; }
        [Key]
        public int intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationdate { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [StringLength(150)]
        public string varContactPerson { get; set; }
        [StringLength(150)]
        public string varContactNo { get; set; }
        [StringLength(150)]
        public string varDesignation { get; set; }
        [StringLength(50)]
        public string varMasterTyep { get; set; }
        public int? intMasterId { get; set; }
    }
}
