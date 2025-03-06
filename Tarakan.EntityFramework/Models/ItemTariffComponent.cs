using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffComponent
{
    public string SrtariffType { get; set; }

    public string ItemId { get; set; }

    public string ClassId { get; set; }

    public DateTime StartingDate { get; set; }

    public string TariffComponentId { get; set; }

    public decimal Price { get; set; }

    /// <summary>
    /// Bisa di set True bila di master itemnya IsAllowDiscount=1
    /// </summary>
    public bool IsAllowDiscount { get; set; }

    public bool IsAllowVariable { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ReferenceNo { get; set; }
}
