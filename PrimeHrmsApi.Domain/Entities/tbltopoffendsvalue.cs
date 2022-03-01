using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tbltopoffendsvalue
    {
        public int? intSeqId { get; set; }
        public int? inttopoffendsvlue { get; set; }
        public int? intCompanyId { get; set; }
    }
}
