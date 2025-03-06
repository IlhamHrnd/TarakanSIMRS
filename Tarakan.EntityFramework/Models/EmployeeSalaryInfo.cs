using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeSalaryInfo
{
    public int PersonId { get; set; }

    public string Npwp { get; set; }

    public string SrpaymentFrequency { get; set; }

    public string SrtaxStatus { get; set; }

    public string BankId { get; set; }

    public string BankAccountNo { get; set; }

    public int NoOfDependent { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string JamsostekNo { get; set; }

    public string SremployeeType { get; set; }

    public bool? IsSalaryManaged { get; set; }

    public string SrincentiveServiceUnitGroup { get; set; }

    public string SrincentivePositionGroup { get; set; }

    public decimal? IncentivePositionPoints { get; set; }

    public string BankAccountName { get; set; }

    public string SrremunerationType { get; set; }
}
