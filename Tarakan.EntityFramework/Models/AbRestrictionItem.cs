using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AbRestrictionItem
{
    public string AbRestrictionId { get; set; }

    public int AbLevel { get; set; }

    public string ZatActiveId { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
