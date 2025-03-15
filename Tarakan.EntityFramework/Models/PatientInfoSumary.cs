using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientInfoSumary
{
    public string PatientId { get; set; } = null!;

    public int? NoteCount { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
