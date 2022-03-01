using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblManualnSOP
    {
        [Key]
        public int intSeqId { get; set; }
        [StringLength(200)]
        public string FilePath { get; set; }
        [StringLength(200)]
        public string FileExtension { get; set; }
        public int? IntCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreation { get; set; }
        public int? intCreatedby { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdate { get; set; }
        public int? intUpdatedby { get; set; }
        [StringLength(500)]
        public string varDocName { get; set; }
    }
}
