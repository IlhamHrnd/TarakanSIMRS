using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathologyAnatomyTissue
{
    public string TissueId { get; set; } = null!;

    public string? TissueName { get; set; }

    public string? SourceOfTissueId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
