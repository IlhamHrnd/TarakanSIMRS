using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuItem
{
    public string MenuItemId { get; set; }

    public string MenuItemName { get; set; }

    public string MenuId { get; set; }

    public string VersionId { get; set; }

    public string SeqNo { get; set; }

    public string ClassId { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
