using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalBenefitRuleDefinition
{
    public long MedicalBenefitRuleDefinitionId { get; set; }

    public int MedicalBenefitInfoId { get; set; }

    public string SremploymentType { get; set; }

    public string SremployeeStatus { get; set; }

    public int? PositionGradeId { get; set; }

    public int? EmployeeGradeId { get; set; }

    public int? PersonId { get; set; }

    public int? AgeFrom { get; set; }

    public int? AgeTo { get; set; }

    public int? ServiceYearFrom { get; set; }

    public int? ServiceYearTo { get; set; }

    public bool? IsUnlimit { get; set; }

    public int? BasicSalaryFactor { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
