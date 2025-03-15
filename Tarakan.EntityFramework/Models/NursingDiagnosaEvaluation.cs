using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingDiagnosaEvaluation
{
    public long Id { get; set; }

    public long? EvaluationId { get; set; }

    public long? InterventionId { get; set; }

    public string? NursingInterventionId { get; set; }

    public string? SrnursingCarePlanning { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }
}
