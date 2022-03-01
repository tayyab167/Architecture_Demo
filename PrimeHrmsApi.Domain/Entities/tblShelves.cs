using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblShelves
    {
        public int? intSeqID { get; set; }
        [StringLength(50)]
        public string varShelves { get; set; }
        [StringLength(50)]
        public string varAbbrevation { get; set; }
        public int? intRackID { get; set; }
        public int? intBinID { get; set; }
        public int? intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intUpdatedBy { get; set; }
    }
}
