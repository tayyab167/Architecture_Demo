using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblStudentHealthHabit
    {
        [Key]
        public int intSeqID { get; set; }
        public int? intStudentID { get; set; }
        public int? intBloodGroup { get; set; }
        public string varDiseases { get; set; }
        public string varAllergic { get; set; }
        public string varMedicineInUse { get; set; }
        public string varTreatmentInUse { get; set; }
        public string vaDisability { get; set; }
        public string vargoodHabits { get; set; }
        public string varBadHabits { get; set; }
        [Key]
        public int intCompanyID { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        public int? intModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtModificationDate { get; set; }
    }
}
