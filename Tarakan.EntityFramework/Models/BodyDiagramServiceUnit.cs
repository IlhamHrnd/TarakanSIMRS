using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BodyDiagramServiceUnit
{
    public string BodyId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
