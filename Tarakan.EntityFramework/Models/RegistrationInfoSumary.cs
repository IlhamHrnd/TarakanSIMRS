using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationInfoSumary
{
    public string RegistrationNo { get; set; } = null!;

    public int NoteCount { get; set; }

    public string CreatedByUserId { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public int NoteMedicalCount { get; set; }

    public int? DocumentCheckListCount { get; set; }
}
