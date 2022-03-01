using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblContactDBFormMaster
    {
        public tblContactDBFormMaster()
        {
            tblContactDBFormDetail = new HashSet<tblContactDBFormDetail>();
        }

        [Key]
        public int intSeqid { get; set; }
        public int? intCompanyid { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationdate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intParentDepId { get; set; }
        public int? intSubDepId { get; set; }
        public int? intDesignation { get; set; }

        [InverseProperty("intMaster")]
        public virtual ICollection<tblContactDBFormDetail> tblContactDBFormDetail { get; set; }
    }
}
