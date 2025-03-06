using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeDisciplinary
{
    public int EmployeeDisciplinaryId { get; set; }

    public int PersonId { get; set; }

    public string SrwarningLevel { get; set; }

    public DateTime IncidentDate { get; set; }

    public DateTime DateIssue { get; set; }

    public string Violation { get; set; }

    public string EffectViolation { get; set; }

    public string AdviceGiven { get; set; }

    public string SanctionGiven { get; set; }

    public string SrviolationDegree { get; set; }

    public string SrviolationType { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ValidUntil { get; set; }
}
