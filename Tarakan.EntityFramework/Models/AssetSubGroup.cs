using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetSubGroup
{
    public string AssetGroupId { get; set; }

    public string AssetSubGroupId { get; set; }

    public string AssetSubGroupName { get; set; }

    public string Initial { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
