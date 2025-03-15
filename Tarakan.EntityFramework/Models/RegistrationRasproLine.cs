using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationRasproLine
{
    public string RegistrationNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public string RasproLineId { get; set; } = null!;

    public string? Condition { get; set; }

    public int? ActionNo { get; set; }

    public int? AntibioticLevel { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
