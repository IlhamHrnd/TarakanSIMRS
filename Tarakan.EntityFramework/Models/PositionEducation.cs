using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionEducation
{
    public int PositionEducationId { get; set; }

    public int PositionId { get; set; }

    public string Srrequirement { get; set; }

    public string SreducationLevel { get; set; }

    public string SreducationField { get; set; }

    public string EducationNotes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
