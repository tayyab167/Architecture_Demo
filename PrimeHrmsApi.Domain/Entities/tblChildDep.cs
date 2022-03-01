using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblChildDep
    {
        [Key]
        public int intSubDepId { get; set; }
        public int? intDepId { get; set; }
        [StringLength(250)]
        public string varName { get; set; }
        public int? intCompanyId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }

        [ForeignKey(nameof(intDepId))]
        [InverseProperty(nameof(tblDep.tblChildDep))]
        public virtual tblDep intDep { get; set; }
    }
}
