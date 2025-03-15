using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VObatKosong
{
    public string ItemId { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public decimal Balance { get; set; }
}
