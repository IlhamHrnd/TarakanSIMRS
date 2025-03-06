using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VObatKosong
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public decimal Balance { get; set; }
}
