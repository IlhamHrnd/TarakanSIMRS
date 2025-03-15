using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WageTransaction
{
    public long WageTransactionId { get; set; }

    public int WageProcessTypeId { get; set; }

    public int PayrollPeriodId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int PersonId { get; set; }

    public string SremployeeType { get; set; } = null!;

    public string SrremunerationType { get; set; } = null!;

    public int OrganizationUnitId { get; set; }

    public int SubOrganizationUnitId { get; set; }

    public string SrpaymentFrequency { get; set; } = null!;

    public string SrtaxStatus { get; set; } = null!;

    public string? SremployeeStatus { get; set; }

    public int? PositionId { get; set; }

    public string? Srreligion { get; set; }

    public string? SremploymentType { get; set; }

    public int? PositionGradeId { get; set; }

    public string? SrmaritalStatus { get; set; }

    public int? ServiceYear { get; set; }

    public int? SalaryTableNumber { get; set; }

    public int? EmployeeGradeId { get; set; }

    public int? NoOfDependent { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsKwi { get; set; }

    public string? SreducationLevel { get; set; }

    public decimal? GradeYear { get; set; }

    public bool? IsNpwp { get; set; }
}
