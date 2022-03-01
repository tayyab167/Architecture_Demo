using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblBooks
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intCategoryID { get; set; }
        [StringLength(50)]
        public string varTitle { get; set; }
        [StringLength(50)]
        public string varAuthor { get; set; }
        [StringLength(50)]
        public string varDescription { get; set; }
        [StringLength(50)]
        public string varEdition { get; set; }
        public int? intYearOfPublish { get; set; }
        [StringLength(50)]
        public string varKeyword { get; set; }
        public int? intNumOfSection { get; set; }
        public int? intNumOfPages { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        [StringLength(500)]
        public string varStatus { get; set; }
    }
}
