using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietMenu
{
    public string DietId { get; set; }

    public string FormOfFood { get; set; }

    public string MenuId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
