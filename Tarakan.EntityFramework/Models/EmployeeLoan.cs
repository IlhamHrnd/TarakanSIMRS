using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeLoan
{
    public int EmployeeLoanId { get; set; }

    public int PersonId { get; set; }

    public DateTime LoanDate { get; set; }

    public decimal Amount { get; set; }

    public decimal? LoanAmountWithInterest { get; set; }

    public decimal? PercentRateOfInterest { get; set; }

    public bool? FlatRate { get; set; }

    public string SrpurposeOfLoan { get; set; }

    public int? NumberOfInstallment { get; set; }

    public decimal? AmountOfInstallment { get; set; }

    public string SrhrpaymentMethod { get; set; }

    public int StartPaymentPeriode { get; set; }

    public int SalaryCodeInstallment { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? LoanNo { get; set; }

    public decimal? CoverageAmount { get; set; }

    public int? CompanyLaborProfileId { get; set; }

    public string Notes { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? InstallmentMethod { get; set; }
}
