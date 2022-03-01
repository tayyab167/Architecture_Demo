using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblAttendanceAllowance
    {
        public tblAttendanceAllowance()
        {
            tblAttendanceAllowanceDetail = new HashSet<tblAttendanceAllowanceDetail>();
        }

        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(1000)]
        public string varName { get; set; }
        [StringLength(10)]
        public string intRowNumId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdationDate { get; set; }
        public bool? IsActive1 { get; set; }
        [StringLength(1000)]
        public string varRuleName1 { get; set; }
        public double? flNoAbsents1 { get; set; }
        public double? flAmount1 { get; set; }
        public bool? IsActive2 { get; set; }
        [StringLength(1000)]
        public string varRuleName2 { get; set; }
        public double? flNoAbsents2 { get; set; }
        public double? flAmount2 { get; set; }
        public bool? IsActive3 { get; set; }
        [StringLength(1000)]
        public string varRuleName3 { get; set; }
        public double? flNoAbsents3 { get; set; }
        public double? flAmount3 { get; set; }
        public int? intCreatedBy { get; set; }
        public int? intUpdatedBy { get; set; }

        [InverseProperty("intAttendanceAllowanceNavigation")]
        public virtual ICollection<tblAttendanceAllowanceDetail> tblAttendanceAllowanceDetail { get; set; }
    }
}
