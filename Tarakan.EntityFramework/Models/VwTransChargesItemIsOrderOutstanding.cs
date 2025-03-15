using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransChargesItemIsOrderOutstanding
{
    public string RegistrationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string FromServiceUnitId { get; set; } = null!;

    public string? ToServiceUnitId { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public string? RoomId { get; set; }

    public string? BedId { get; set; }
}
