using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AzureResource
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Uri { get; set; }

    public string Type { get; set; }

    public long AzureApplicationProfileId { get; set; }

    public virtual AzureApplicationProfile AzureApplicationProfile { get; set; }
}
