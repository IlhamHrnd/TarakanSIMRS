using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeePeriodicStructuralBenefit
{
    public int CounterId { get; set; }

    public int PayrollPeriodId { get; set; }

    public int SalaryComponentId { get; set; }

    public int PersonId { get; set; }

    public int OrganizationUnitId { get; set; }

    public int PositionId { get; set; }

    public string? SrstructuralBenefitsType { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? NumberOfDays { get; set; }
}
