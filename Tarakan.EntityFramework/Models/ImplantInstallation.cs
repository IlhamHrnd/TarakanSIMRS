using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ImplantInstallation
{
    public string BookingNo { get; set; } = null!;

    public string SeqNo { get; set; } = null!;

    public string ImplantType { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public short Qty { get; set; }

    public string PlacementSite { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
