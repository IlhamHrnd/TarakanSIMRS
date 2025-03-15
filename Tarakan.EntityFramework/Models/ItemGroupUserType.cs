using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemGroupUserType
{
    public string ItemGroupId { get; set; } = null!;

    public string SruserType { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
