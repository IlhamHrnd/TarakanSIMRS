using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Morphology
{
    public string MorphologyId { get; set; } = null!;

    public string? DiagnoseId { get; set; }

    public string MorphologyName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
