using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionFunctionalArea
{
    public int PositionFunctionalAreaId { get; set; }

    public int PositionId { get; set; }

    public string SrpositionFunctionalArea { get; set; }

    public string Description { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
