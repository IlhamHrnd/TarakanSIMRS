using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class IncidentType
{
    public string SrincidentType { get; set; }

    public string ComponentId { get; set; }

    public string ComponentName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
