using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SanitationWasteItemBalance
{
    public string SrwasteType { get; set; }

    public decimal? Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
