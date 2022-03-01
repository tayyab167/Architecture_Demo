using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblPMSTypeNew
    {
        public int? intSeqID { get; set; }
        [StringLength(50)]
        public string varTypeName { get; set; }
        public int? intPercentageGPA { get; set; }
        public int? intCompanyId { get; set; }
    }
}
