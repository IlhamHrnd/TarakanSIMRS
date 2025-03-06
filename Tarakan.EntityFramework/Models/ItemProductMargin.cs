using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMargin
{
    public string MarginId { get; set; }

    public string MarginName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual ICollection<ItemProductMarginValue> ItemProductMarginValues { get; set; } = new List<ItemProductMarginValue>();
}
