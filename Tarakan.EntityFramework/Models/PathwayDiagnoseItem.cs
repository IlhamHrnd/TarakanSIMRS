using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathwayDiagnoseItem
{
    public string PathwayId { get; set; } = null!;

    public string DiagnoseId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
