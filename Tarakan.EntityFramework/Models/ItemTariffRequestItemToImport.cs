using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffRequestItemToImport
{
    public string ReferenceNo { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string SrtariffType { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public decimal? OldPrice { get; set; }

    public decimal? NewPrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? GeneralPrice { get; set; }

    public string? ItemGroupId { get; set; }

    public string? ItemName { get; set; }
}
