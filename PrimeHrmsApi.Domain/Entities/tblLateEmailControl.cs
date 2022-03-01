using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblLateEmailControl
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtUpdateDate { get; set; }
        public int? intUpdateBy { get; set; }
        public int? intCompanyID { get; set; }
        public string varFirstEmailMsg { get; set; }
        [StringLength(50)]
        public string varFirtEmailCC { get; set; }
        [StringLength(50)]
        public string varFirtEmailBCC { get; set; }
        public string varSecondEmailMsg { get; set; }
        [StringLength(50)]
        public string varSecondEmailCC { get; set; }
        [StringLength(50)]
        public string varSecondEmailBCC { get; set; }
        public string varthrdEmailMsg { get; set; }
        [StringLength(50)]
        public string varthrdEmailCC { get; set; }
        [StringLength(50)]
        public string varthrdEmailBCC { get; set; }
        public string varFourthEmailMsg { get; set; }
        [StringLength(50)]
        public string varFourthEmailCC { get; set; }
        [StringLength(50)]
        public string varFourthEmailBCC { get; set; }
        public bool? isFirstEmailToEmp { get; set; }
        public bool? isSecondEmailToEmp { get; set; }
        public bool? isThirdEmailToEmp { get; set; }
        public bool? isFourthEmailToEmp { get; set; }
        public bool? isFifthEmailToEmp { get; set; }
        public bool? isActive1 { get; set; }
        public bool? isActive2 { get; set; }
        public bool? isActive3 { get; set; }
        public bool? isActive4 { get; set; }
        public bool? isActive5 { get; set; }
        public bool? isAllowLead1 { get; set; }
        public bool? isAllowLead2 { get; set; }
        public bool? isAllowLead3 { get; set; }
        public bool? isAllowLead4 { get; set; }
        public bool? isAllowLead5 { get; set; }
        public bool? isLateTime1 { get; set; }
        public bool? isLateTime2 { get; set; }
        public bool? isLateTime3 { get; set; }
        public bool? isLateTime4 { get; set; }
        public bool? isLateTime5 { get; set; }
        public string varFifthEmailMsg { get; set; }
        [StringLength(50)]
        public string varFifthEmailCC { get; set; }
        [StringLength(50)]
        public string varFifthEmailTO { get; set; }
        [StringLength(50)]
        public string varFifthEmailBCC { get; set; }
        [StringLength(50)]
        public string varFourthEmailTO { get; set; }
        [StringLength(50)]
        public string varthrdEmailTO { get; set; }
        [StringLength(50)]
        public string varSecondEmailTO { get; set; }
        [StringLength(50)]
        public string varFirtEmailTO { get; set; }
        public bool? isAllowOnlyLatesInLateEmail { get; set; }
        public bool? isShowWHInsteadLeaves { get; set; }
        public string varFirstEmailMsgTL { get; set; }
        public string varSecondEmailMsgTL { get; set; }
        public string varthrdEmailMsgTL { get; set; }
        public string varFourthEmailMsgTL { get; set; }
        public string varFifthEmailMsgTL { get; set; }
        public bool? isWarningLetter3 { get; set; }
        public bool? isWarningLetter4 { get; set; }
        public bool? isWarningLetter5 { get; set; }
        public int? intWarningTemplateId3 { get; set; }
        public int? intWarningTemplateId4 { get; set; }
        public int? intWarningTemplateId5 { get; set; }
    }
}
