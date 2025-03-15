using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BirthAttendantsRecord
{
    public string RegistrationNo { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public string? SrmidwivesType { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
