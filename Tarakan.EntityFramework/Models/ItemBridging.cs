using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemBridging
{
    public string ItemId { get; set; }

    public string SrbridgingType { get; set; }

    public string BridgingId { get; set; }

    public string BridgingName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string BridgingGroupId { get; set; }

    public string BridgingGroupName { get; set; }

    public string ItemIdExternal { get; set; }
}
