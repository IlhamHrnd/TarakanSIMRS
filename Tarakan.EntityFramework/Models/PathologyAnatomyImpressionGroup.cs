using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathologyAnatomyImpressionGroup
{
    public string GroupId { get; set; }

    public string GroupName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
