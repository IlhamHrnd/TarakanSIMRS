using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AzureSubscription
{
    public long Id { get; set; }

    public string SubscriptionId { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<AzureApplicationProfile> AzureApplicationProfiles { get; set; } = new List<AzureApplicationProfile>();
}
