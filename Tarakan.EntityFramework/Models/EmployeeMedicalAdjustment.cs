using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeMedicalAdjustment
{
    public int EmployeeMedicalAdjustmentId { get; set; }

    public int PersonId { get; set; }

    public int YearPeriodId { get; set; }

    public int MedicalBenefitInfoId { get; set; }

    public DateTime AdjustmentDate { get; set; }

    public decimal AdjustmentAmount { get; set; }

    public decimal DependentAdjustmentAmount { get; set; }

    public bool IsApproved { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
