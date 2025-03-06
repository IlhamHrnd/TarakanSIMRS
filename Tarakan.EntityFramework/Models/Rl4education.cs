using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Rl4education
{
    public int Rl4educationId { get; set; }

    public string Rl4educationCode { get; set; }

    public string Rl4educationName { get; set; }

    public string AcademicTitle { get; set; }

    public string SreducationLevel { get; set; }

    public string SrfieldLabor { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
