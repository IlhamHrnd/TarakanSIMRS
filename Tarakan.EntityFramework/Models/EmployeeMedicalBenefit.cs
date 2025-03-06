using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeMedicalBenefit
{
    public long EmployeeMedicalBenefitId { get; set; }

    public int PersonId { get; set; }

    public int MedicalBenefitInfoId { get; set; }

    public int YearPeriodId { get; set; }

    public bool? IsUnlimited { get; set; }

    public string SrmedicalPaidRules { get; set; }

    public string GuarantorId { get; set; }

    public decimal? EmployeeBenefit { get; set; }

    public decimal? EmployeeUsedAmount { get; set; }

    public decimal? EmployeeAdjustmentAmount { get; set; }

    public decimal? EmployeeUnusedAmount { get; set; }

    public int? NoOfDependent { get; set; }

    public string DependentGuarantorId { get; set; }

    public decimal? DependentBenefit { get; set; }

    public decimal? DependentUsedAmount { get; set; }

    public decimal? DependentAdjustmentAmount { get; set; }

    public decimal? DependentUnusedAmount { get; set; }

    public decimal? TotalBenefit { get; set; }

    public decimal? TotalUsedAmount { get; set; }

    public decimal? TotalAdjustmentAmount { get; set; }

    public decimal? TotalUnusedAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
