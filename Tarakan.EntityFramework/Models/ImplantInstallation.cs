using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ImplantInstallation
{
    public string BookingNo { get; set; }

    public string SeqNo { get; set; }

    public string ImplantType { get; set; }

    public string SerialNo { get; set; }

    public short Qty { get; set; }

    public string PlacementSite { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
