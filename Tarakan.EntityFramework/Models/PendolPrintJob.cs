using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PendolPrintJob
{
    public string Sep { get; set; } = null!;

    public string DataSep { get; set; } = null!;

    public string DataBarcode { get; set; } = null!;

    public byte IsPrinted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? IpAddress { get; set; }
}
