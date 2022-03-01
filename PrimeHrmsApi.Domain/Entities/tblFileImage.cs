using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblFileImage
    {
        public int? intSeqid { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string varfileName { get; set; }
        public int? intCompanyId { get; set; }
        public int? intMasterId { get; set; }
        public bool? isApprproved { get; set; }
    }
}
