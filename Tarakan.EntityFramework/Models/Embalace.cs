using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Embalace
{
    public string EmbalaceId { get; set; } = null!;

    public string EmbalaceName { get; set; } = null!;

    public string EmbalaceLabel { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? EmbalaceFeeAmount { get; set; }
}
