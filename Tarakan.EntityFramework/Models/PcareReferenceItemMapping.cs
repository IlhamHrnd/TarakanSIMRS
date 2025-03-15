using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PcareReferenceItemMapping
{
    public string ReferenceId { get; set; } = null!;

    public string MappingWithId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
