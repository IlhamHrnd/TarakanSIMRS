using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LocationExceptionDistributionConfirm
{
    public string LocationId { get; set; } = null!;

    public string LocationExceptionId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
