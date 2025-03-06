using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ZatActiveInteraction
{
    public string ZatActiveId { get; set; }

    public string InteractionZatActiveId { get; set; }

    public string Interaction { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
