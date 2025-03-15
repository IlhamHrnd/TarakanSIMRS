using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class IhsMapping
{
    public string IhsId { get; set; } = null!;

    public string SrsatuSehatMapping { get; set; } = null!;

    public string AvicennaId { get; set; } = null!;

    public DateTime? LastCreatedDateTime { get; set; }

    public string? LastCreatedByUserId { get; set; }
}
