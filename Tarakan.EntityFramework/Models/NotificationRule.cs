using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NotificationRule
{
    public Guid RuleId { get; set; }

    public string SerializedObject { get; set; } = null!;

    public virtual ICollection<ScomalertEvent> ScomalertEvents { get; set; } = new List<ScomalertEvent>();
}
