using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SalaryComponentRuleDefinition
{
    public long SalaryComponentRuleDefinitionId { get; set; }

    public int SalaryComponentId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public int? OrganizationUnitId { get; set; }

    public string SremployeeStatus { get; set; }

    public int? PositionId { get; set; }

    public string Srreligion { get; set; }

    public int? PersonId { get; set; }

    public string SremploymentType { get; set; }

    public int? PositionGradeId { get; set; }

    public string SrmaritalStatus { get; set; }

    public string ServiceYear { get; set; }

    public int? SalaryTableNumber { get; set; }

    public int? EmployeeGradeId { get; set; }

    public int? NoOfDependent { get; set; }

    public int? AttedanceMatrixId { get; set; }

    public decimal? NominalAmount { get; set; }

    public decimal? PercentageAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? PercentageComponentId { get; set; }

    public string SreducationLevelId { get; set; }

    public string SremployeeType { get; set; }

    public string ServiceUnitId { get; set; }
}
