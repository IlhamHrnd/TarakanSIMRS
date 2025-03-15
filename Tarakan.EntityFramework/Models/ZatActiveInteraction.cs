using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ZatActiveInteraction
{
    public string ZatActiveId { get; set; } = null!;

    public string InteractionZatActiveId { get; set; } = null!;

    public string Interaction { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
