using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RecipeMarginValue
{
    public int CounterId { get; set; }

    public decimal StartingValue { get; set; }

    public decimal EndingValue { get; set; }

    public decimal RecipeAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
