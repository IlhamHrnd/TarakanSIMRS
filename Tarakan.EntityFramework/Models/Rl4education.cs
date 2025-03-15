using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Rl4education
{
    public int Rl4educationId { get; set; }

    public string Rl4educationCode { get; set; } = null!;

    public string Rl4educationName { get; set; } = null!;

    public string? AcademicTitle { get; set; }

    public string SreducationLevel { get; set; } = null!;

    public string SrfieldLabor { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
