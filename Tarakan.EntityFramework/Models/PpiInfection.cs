using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiInfection
{
    public string RegistrationNo { get; set; } = null!;

    public string SrinfectionType { get; set; } = null!;

    public short? DaysTo { get; set; }

    public string? Cultures { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
