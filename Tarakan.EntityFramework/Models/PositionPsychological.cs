using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionPsychological
{
    public int PositionPsychologicalId { get; set; }

    public int PositionId { get; set; }

    public string Srpsychological { get; set; }

    public string SroperandType { get; set; }

    public string PsychologicalValue { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
