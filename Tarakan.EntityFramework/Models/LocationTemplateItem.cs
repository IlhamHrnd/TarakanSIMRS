using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LocationTemplateItem
{
    public string TemplateNo { get; set; }

    public string ItemId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
