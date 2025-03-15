using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BedStatusHistory
{
    public long TransactionId { get; set; }

    public string BedId { get; set; } = null!;

    public string SrbedStatusFrom { get; set; } = null!;

    public string SrbedStatusTo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? TransferNo { get; set; }
}
