using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SmfItemService
{
    public string SmfId { get; set; }

    public string ItemId { get; set; }

    public bool? IsVisible { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
