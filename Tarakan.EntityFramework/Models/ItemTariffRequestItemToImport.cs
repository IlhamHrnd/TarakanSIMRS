using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffRequestItemToImport
{
    public string ReferenceNo { get; set; }

    public DateTime StartingDate { get; set; }

    public string SrtariffType { get; set; }

    public string ItemId { get; set; }

    public string ClassId { get; set; }

    public string TariffComponentId { get; set; }

    public decimal? OldPrice { get; set; }

    public decimal? NewPrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? GeneralPrice { get; set; }

    public string ItemGroupId { get; set; }

    public string ItemName { get; set; }
}
