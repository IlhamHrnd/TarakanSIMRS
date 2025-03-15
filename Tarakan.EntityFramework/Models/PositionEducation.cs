using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionEducation
{
    public int PositionEducationId { get; set; }

    public int PositionId { get; set; }

    public string Srrequirement { get; set; } = null!;

    public string SreducationLevel { get; set; } = null!;

    public string SreducationField { get; set; } = null!;

    public string? EducationNotes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
