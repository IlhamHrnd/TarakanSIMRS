using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PendolPrintJob
{
    public string Sep { get; set; }

    public string DataSep { get; set; }

    public string DataBarcode { get; set; }

    public byte IsPrinted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string IpAddress { get; set; }
}
