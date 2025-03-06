using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantAppliedPosition
{
    public int ApplicantAppliedPositionsId { get; set; }

    public int ApplicantId { get; set; }

    public int PositionId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
