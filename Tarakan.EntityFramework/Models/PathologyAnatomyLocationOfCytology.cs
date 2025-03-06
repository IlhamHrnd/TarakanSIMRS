using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathologyAnatomyLocationOfCytology
{
    public string LocationId { get; set; }

    public string LocationName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
