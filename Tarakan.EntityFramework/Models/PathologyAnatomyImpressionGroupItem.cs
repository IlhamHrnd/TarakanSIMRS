using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathologyAnatomyImpressionGroupItem
{
    public string GroupId { get; set; }

    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
