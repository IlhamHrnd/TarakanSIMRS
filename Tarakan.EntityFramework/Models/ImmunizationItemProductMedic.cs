using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ImmunizationItemProductMedic
{
    public string ImmunizationId { get; set; }

    public string ItemId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
