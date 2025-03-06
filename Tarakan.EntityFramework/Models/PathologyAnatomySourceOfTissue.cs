using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathologyAnatomySourceOfTissue
{
    public string SourceOfTissueId { get; set; }

    public string SourceOfTissueName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
