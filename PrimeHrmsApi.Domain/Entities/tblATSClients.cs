using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblATSClients
    {
        public int? intSeqId { get; set; }
        [StringLength(50)]
        public string ClientName { get; set; }
        [StringLength(100)]
        public string ClientEmail { get; set; }
        [StringLength(50)]
        public string ClientPhoneNumber { get; set; }
        [StringLength(300)]
        public string ClientLogo { get; set; }
        public int? intCompanyId { get; set; }
        [StringLength(50)]
        public string dtCreationDate { get; set; }
        [StringLength(50)]
        public string dtUpdationDate { get; set; }
        public int? intUpdatedBy { get; set; }
        public int? intCreatedBy { get; set; }
        [StringLength(1000)]
        public string ClientAddress { get; set; }
        [StringLength(100)]
        public string ClientContactPerson { get; set; }
        [StringLength(200)]
        public string ClientPassword { get; set; }
        public int? intUserId { get; set; }
    }
}
