using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AzureResource
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Uri { get; set; } = null!;

    public string Type { get; set; } = null!;

    public long AzureApplicationProfileId { get; set; }

    public virtual AzureApplicationProfile AzureApplicationProfile { get; set; } = null!;
}
