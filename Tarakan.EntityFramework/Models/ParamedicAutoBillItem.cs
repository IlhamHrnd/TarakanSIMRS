using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicAutoBillItem
{
    public string ParamedicId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string SritemUnit { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsGenerateOnRegistration { get; set; }

    public bool IsGenerateOnReferral { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
