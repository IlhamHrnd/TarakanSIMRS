using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemIdiItemSmf
{
    public string IdiCode { get; set; }

    public string ItemId { get; set; }

    public string SmfId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
