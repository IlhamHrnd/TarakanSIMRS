using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuItemExtra
{
    public string SeqNo { get; set; }

    public string MenuId { get; set; }

    public DateTime StartingDate { get; set; }

    public string SrmealSet { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
