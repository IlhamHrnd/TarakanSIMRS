using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeTrainingExternalTrainer
{
    public int EmployeeTrainingId { get; set; }

    public string ExternalTrainerSeqNo { get; set; }

    public string ExternalTrainerName { get; set; }

    public string PositionAs { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
