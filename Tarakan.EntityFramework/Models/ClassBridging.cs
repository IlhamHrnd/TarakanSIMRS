using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClassBridging
{
    public string ClassId { get; set; }

    public string SrbridgingType { get; set; }

    public string BridgingId { get; set; }

    public string BridgingName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
