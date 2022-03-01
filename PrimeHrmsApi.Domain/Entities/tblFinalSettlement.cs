using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrimeHrmsApi.Domain.Entities
{
    public partial class tblFinalSettlement
    {
        [Key]
        public int intSeqId { get; set; }
        public int? intCompanyId { get; set; }
        public int? intEmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtCreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtToDate { get; set; }
        public int? intDaysBWDates { get; set; }
        public int? intEncashBWDatesAmount { get; set; }
        public double? intDaysEnterEncash { get; set; }
        public double? intDaysEnterAmount { get; set; }
        public double? flBonus { get; set; }
        public double? flOtherEarning { get; set; }
        public double? flIncomeTax { get; set; }
        public double? flAdvance { get; set; }
        public double? flLoan { get; set; }
        public double? flOtherDeduction { get; set; }
        public double? flLessNoticePeriod { get; set; }
        public double? flTotalEarning { get; set; }
        public double? flTotalDeduction { get; set; }
        public double? flNetPayableAmount { get; set; }
        public double? flRoundupAmount { get; set; }
        public double? flTotalNetAmount { get; set; }
        public double? flSecurity { get; set; }
        public double? flEmpPF { get; set; }
        public double? flEmprPF { get; set; }
        public int? intDaysLNP { get; set; }
        public bool? isManageInPayroll { get; set; }
        public double? flEmpEOBI { get; set; }
        public double? flOPD { get; set; }
        public double? flEmpPFDeduction { get; set; }
        public double? flOtAmountFinal { get; set; }
        public double? flCanteenAmount { get; set; }
        public double? flOtherAmount { get; set; }
        public double? flExtraPayrollAmount { get; set; }
        public double? flAbsentAmount { get; set; }
        public double? flAbsentDays { get; set; }
    }
}
