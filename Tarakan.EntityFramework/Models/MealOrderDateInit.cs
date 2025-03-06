using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MealOrderDateInit
{
    public DateTime MealOrderDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
