using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransChargesItemIsOrderOutstanding
{
    public string RegistrationNo { get; set; }

    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string FromServiceUnitId { get; set; }

    public string ToServiceUnitId { get; set; }

    public string ReferenceNo { get; set; }

    public string RoomId { get; set; }

    public string BedId { get; set; }
}
