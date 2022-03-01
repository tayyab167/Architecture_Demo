using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblMyMail
    {
        public int intSeqId { get; set; }
        public int? intCourierId { get; set; }
        public bool? isRecieved { get; set; }
        public int? intCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdatedDate { get; set; }
        public int? intCreationBy { get; set; }
        public int? intUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtDate { get; set; }
        [StringLength(50)]
        public string varCompanyName { get; set; }
        [StringLength(50)]
        public string varSenderName { get; set; }
        [StringLength(50)]
        public string varSendingFor { get; set; }
        [StringLength(200)]
        public string varSubject { get; set; }
        [StringLength(200)]
        public string varEDMarkedTO { get; set; }
        [StringLength(200)]
        public string varReceivedBy { get; set; }
        [StringLength(5)]
        public string varType { get; set; }
        public int? intEmployeeId { get; set; }
    }
}
