using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class FoodPackage
{
    public string FoodId { get; set; } = null!;

    public string FoodDetailId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
