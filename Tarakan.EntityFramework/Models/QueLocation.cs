using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QueLocation
{
    public int LocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public bool? LocationStatus { get; set; }

    public string? LocationMedia { get; set; }

    public bool? LocationMediaStatus { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public string? InsertByUserId { get; set; }

    public DateTime? UpdateDateTime { get; set; }

    public string? UpdateByUserId { get; set; }

    public bool? ShowMedia { get; set; }
}
