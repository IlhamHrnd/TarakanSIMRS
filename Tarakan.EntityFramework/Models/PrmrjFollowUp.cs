using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrmrjFollowUp
{
    public string RegistrationInfoMedicId { get; set; } = null!;

    public string? ImportantClinicalNotes { get; set; }

    public string? Planning { get; set; }

    public string? Remark { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
