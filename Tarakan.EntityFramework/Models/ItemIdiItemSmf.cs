using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemIdiItemSmf
{
    public string IdiCode { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string SmfId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
