using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemLaboratoryProfile
{
    public string ParentItemId { get; set; } = null!;

    public string DetailItemId { get; set; } = null!;

    public int? DisplaySequence { get; set; }

    public bool? IsDisplayInResult { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
