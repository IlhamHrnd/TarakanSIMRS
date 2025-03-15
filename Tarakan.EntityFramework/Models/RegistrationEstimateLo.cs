using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationEstimateLo
{
    public string RegistrationNo { get; set; } = null!;

    public string? Los { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
