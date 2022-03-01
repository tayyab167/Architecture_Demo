using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblModuleRights
    {
        public int? intSeqid { get; set; }
        public int? intCompanyID { get; set; }
        public int? intModuleID { get; set; }
        public bool? isActive { get; set; }
    }
}
