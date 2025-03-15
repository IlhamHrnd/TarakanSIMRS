using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeTrainingExternalTrainer
{
    public int EmployeeTrainingId { get; set; }

    public string ExternalTrainerSeqNo { get; set; } = null!;

    public string ExternalTrainerName { get; set; } = null!;

    public string PositionAs { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
