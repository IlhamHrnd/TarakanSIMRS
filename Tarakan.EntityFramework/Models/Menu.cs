using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Menu
{
    public string MenuId { get; set; }

    public string MenuName { get; set; }

    public bool IsActive { get; set; }

    public bool? IsExtra { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
