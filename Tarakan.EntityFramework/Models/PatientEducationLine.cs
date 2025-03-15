using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientEducationLine
{
    public string RegistrationNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public string SrpatientEducation { get; set; } = null!;

    public string? EducationNotes { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
