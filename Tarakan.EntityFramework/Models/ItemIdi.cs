using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemIdi
{
    public string IdiCode { get; set; } = null!;

    public string IdiName { get; set; } = null!;

    public string? Icd9Cm { get; set; }

    public decimal? F1 { get; set; }

    public decimal? F21 { get; set; }

    public decimal? F22 { get; set; }

    public decimal? F23 { get; set; }

    public decimal? F3 { get; set; }

    public decimal? F4 { get; set; }

    public decimal? Rvu { get; set; }

    public decimal? Price { get; set; }

    public string? Specialist { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
