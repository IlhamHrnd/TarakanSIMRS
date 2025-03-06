using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeePerformanceAppraisal
{
    public int PerformanceAppraisalId { get; set; }

    public int PersonId { get; set; }

    public int? ParticipantItemId { get; set; }

    public string YearPeriod { get; set; }

    public string SrquarterPeriod { get; set; }

    public decimal? Score { get; set; }

    public string ScoreText { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
