using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionWorkExperience
{
    public int PositionWorkExperienceId { get; set; }

    public int PositionId { get; set; }

    public string Srrequirement { get; set; } = null!;

    public string SrlineBusiness { get; set; } = null!;

    public int YearExperience { get; set; }

    public string WorkExperienceNotes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
