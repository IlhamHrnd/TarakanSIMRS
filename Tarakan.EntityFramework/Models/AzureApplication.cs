using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AzureApplication
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string TenantId { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public string Secret { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<AzureApplicationProfile> AzureApplicationProfiles { get; set; } = new List<AzureApplicationProfile>();
}
