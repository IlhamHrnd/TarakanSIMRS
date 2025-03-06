using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AzureApplication
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string TenantId { get; set; }

    public string ClientId { get; set; }

    public string Secret { get; set; }

    public string Description { get; set; }

    public virtual ICollection<AzureApplicationProfile> AzureApplicationProfiles { get; set; } = new List<AzureApplicationProfile>();
}
