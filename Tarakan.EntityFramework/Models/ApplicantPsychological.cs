using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantPsychological
{
    public int ApplicantPsychologicalId { get; set; }

    public int ApplicantId { get; set; }

    public string Srpsychological { get; set; } = null!;

    public string SroperandType { get; set; } = null!;

    public string PsychologicalValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
