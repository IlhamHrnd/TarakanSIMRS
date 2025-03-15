using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SalaryComponent
{
    public int SalaryComponentId { get; set; }

    public string SalaryComponentCode { get; set; } = null!;

    public string SalaryComponentName { get; set; } = null!;

    public string SrsalaryType { get; set; } = null!;

    public string? SrsalaryCategory { get; set; }

    public string? SrincomeTaxMethod { get; set; }

    public string? SrdeductionType { get; set; }

    public string? SrjamsostekType { get; set; }

    public decimal? Amount { get; set; }

    public double FaktorRule { get; set; }

    public string? FaktorRuleDisplay { get; set; }

    public int? SalaryComponentRoundingId { get; set; }

    public bool? DisplayInPaySlip { get; set; }

    public bool? DisplayInPayRekapReport { get; set; }

    public bool? IsOrganizationUnit { get; set; }

    public bool? IsEmployeeStatus { get; set; }

    public bool? IsPosition { get; set; }

    public bool? IsReligion { get; set; }

    public bool? IsEmployee { get; set; }

    public bool? IsEmploymentType { get; set; }

    public bool? IsPositionGrade { get; set; }

    public bool? IsMaritalStatus { get; set; }

    public bool? IsServiceYear { get; set; }

    public bool? IsSalaryTableNumber { get; set; }

    public bool? IsEmployeeGrade { get; set; }

    public bool? IsNoOfDependent { get; set; }

    public bool? IsAttedanceMatrixId { get; set; }

    public bool? IsComponent1 { get; set; }

    public bool? IsComponent2 { get; set; }

    public bool? IsComponent3 { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsKwi { get; set; }

    public bool? IsEducationLevel { get; set; }

    public bool? IsEmployeeType { get; set; }

    public bool? IsServiceUnitId { get; set; }

    public bool? IsPeriodicSalary { get; set; }

    public decimal? MinAmount { get; set; }

    public decimal? MaxAmount { get; set; }

    public bool? IsThr { get; set; }

    public string? NormalBalance { get; set; }

    public bool? IsDisplayInThrSlip { get; set; }

    public int? ChartOfAccountIdThr { get; set; }

    public int? SubLedgerId { get; set; }

    public int? SubLedgerIdThr { get; set; }

    public string? NormalBalanceThr { get; set; }

    public string? SrsalaryComponentGroup { get; set; }

    public int? ChartOfAccountIdIndirect { get; set; }

    public string? NormalBalanceIndirect { get; set; }

    public int? SubLedgerIdIndirect { get; set; }

    public int? ChartOfAccountIdThrIndirect { get; set; }

    public string? NormalBalanceThrIndirect { get; set; }

    public int? SubLedgerIdThrIndirect { get; set; }
}
